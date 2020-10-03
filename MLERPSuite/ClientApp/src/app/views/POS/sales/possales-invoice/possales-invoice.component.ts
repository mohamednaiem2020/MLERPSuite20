import { Component, OnInit, ViewChild } from '@angular/core';
import {
    FormGroup, FormControl, Validators, FormBuilder,
    AsyncValidatorFn
} from '@angular/forms';
import { CustomValidators } from 'ngx-custom-validators';
import { NavigationBarService } from 'app/views/services/navigation-bar.service'
import { HttpClient } from '@angular/common/http';
import { BaseFormComponent } from 'app/base.form.component'
import { ActivatedRoute, Router } from '@angular/router';
import { map, startWith } from 'rxjs/operators';
import { Observable } from 'rxjs';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { possalesheader, possalesDetails } from 'app/views/POS/sales/possales-invoice/possalesinvoice';
import { PossalesInvoiceService } from 'app/views/POS/sales/possales-invoice/possales-invoice.service'
export interface PeriodicElement {
    Item: string;
    Unit: string;
    Quantity: number;
    Price: number;
    Total: number;
}


const ELEMENT_DATA: PeriodicElement[] = [
    { Item: 'Hydrogen', Unit: 'PC', Quantity: 3, Price: 2.50, Total: 6.63 },
    { Item: 'Helium', Unit: 'CRT', Quantity: 4, Price: 2.68, Total: 7.32 },
    { Item: 'Lithium', Unit: '24', Quantity: 6, Price: 20.60, Total: 82.53 },
];

@Component({
    selector: 'app-possales-invoice',
    templateUrl: './possales-invoice.component.html',
    styleUrls: ['./possales-invoice.component.scss']
})
/** POSSalesInvoice component*/
export class PossalesInvoiceComponent extends BaseFormComponent implements OnInit {
    /** POSSalesInvoice ctor */
    // #Region forms and Common variables
    console = console;
    InvoiceHeaderForm: FormGroup;
    InvoiceDetailsForm: FormGroup;
    possalesheaderRecord: possalesheader;
    invoiceId?: number;
    selectedItem: any;
    itemId?: number;
    selectedCustomer: any;

    possalesDetailsRecord: possalesDetails;
    detailsId?: number;

    //#Region drop down values
    documents: any[];
    types: any[];
    units: any[];



    //#Region Autocompelete
    myControlCustomer = new FormControl();
    optionsCustomer: any[];
    myControlItem = new FormControl();
    optionsItem: any[];



    //#Region table defination
    displayedColumns: string[] = ['Item', 'Unit', 'Quantity', 'Price', 'Total'];
    dataSource = new MatTableDataSource(ELEMENT_DATA);
    @ViewChild(MatPaginator) paginator: MatPaginator;
    @ViewChild(MatSort) sort: MatSort;



    // #Region Intilize screen
    constructor(private fb: FormBuilder, private navigationBarService: NavigationBarService, private http: HttpClient,
        private possalesInvoiceService: PossalesInvoiceService,
        private router: Router, private activatedRoute: ActivatedRoute) {
        super();

        this.possalesInvoiceService
            .getDocuments()
            .subscribe(result => {

                this.documents = result;

            }, error => console.log(error));
    }
    ngOnInit() {
        //Intialize toolbar event emmiter
        if (this.navigationBarService.subsVarOut == undefined) {
            this.navigationBarService.subsVarOut = this.navigationBarService.
                invokeHandler.subscribe((name: string) => {
                    if (name == "New")
                        this.New();
                    else if (name == "Save")
                        this.Save();
                    else if (name == "Delete")
                        this.Delete();
                    else if (name == "FirstRecord")
                        this.FirstRecord();
                    else if (name == "PreviousRecord")
                        this.PreviousRecord();
                    else if (name == "NextRecord")
                        this.NextRecord();
                    else if (name == "LastRecord")
                        this.LastRecord();
                    else if (name == "Search")
                        this.Search();
                    else if (name == "PageLoad")
                        this.PageLoad();
                });
        }


        //Intialize controls properties
        this.InvoiceHeaderForm = this.fb.group({
            invoiceId: new FormControl({ value: '', disabled: true }),
            documentId: new FormControl('', Validators.required),
            invPOSSalesTypeId: new FormControl('', Validators.required),
            invoiceCode: new FormControl('', Validators.required),
            invoiceDate: new FormControl('', Validators.required),
            custId: new FormControl(''),
            totalAmount: new FormControl(''),
            netAmount: new FormControl(''),
            note: new FormControl(''),
        })

        this.InvoiceDetailsForm = this.fb.group({
            detailsId: new FormControl({ value: '', disabled: true }),
            itemId: new FormControl('', Validators.required),
            unitId: new FormControl('', Validators.required),
            quantity: new FormControl('', Validators.required),
            price: new FormControl('', Validators.required),
            totalAmountDetails: new FormControl(''),
            netAmountDetails: new FormControl(''),
        })



        this.dataSource.paginator = this.paginator;
        this.dataSource.sort = this.sort;


        this.myControlItem.valueChanges.subscribe(
            term => {
                if (term != '') {
                    this.possalesInvoiceService.getItems(term).subscribe(
                        result => {
                            this.optionsItem = result;
                        })
                }
            })

        this.myControlCustomer.valueChanges.subscribe(
            term => {
                if (term != '') {
                    this.possalesInvoiceService.getCustomers(term).subscribe(
                        result => {
                            this.optionsCustomer = result;
                        })
                }
            })
    }

    // #Region Event handler
    New() {
        this.IntalizeScreen();
    }
    Save() {
        this.SaveHeader();
    }
    Delete() {
        this.DeleteHeader();
    }
    FirstRecord() {
        this.Navigate("First", 0);
    }
    PreviousRecord() {
        this.Navigate("Previous", this.invoiceId);
    }
    NextRecord() {
        this.Navigate("Next", this.invoiceId);
    }
    LastRecord() {
        this.Navigate("Last", 0);
    }
    Search() {
        this.Navigate("Search", this.invoiceId);
    }

    // #Region Main functions
    PageLoad() {
        this.IntalizeScreen();
    }
    SaveHeader() {

        var possalesheaderRecord = (this.invoiceId && this.invoiceId != 0) ? this.possalesheaderRecord : <possalesheader>{};
        possalesheaderRecord.documentId = parseInt(this.InvoiceHeaderForm.get("documentId").value);
        possalesheaderRecord.invPOSSalesTypeId = parseInt(this.InvoiceHeaderForm.get("invPOSSalesTypeId").value);
        possalesheaderRecord.invoiceCode = this.InvoiceHeaderForm.get("invoiceCode").value;
        possalesheaderRecord.invoiceDate = this.InvoiceHeaderForm.get("invoiceDate").value;
        possalesheaderRecord.custId = parseInt(this.selectedCustomer.id);
        possalesheaderRecord.totalAmount = 0;// this.InvoiceHeaderForm.get("totalAmount").value;
        possalesheaderRecord.netAmount = 0;// this.InvoiceHeaderForm.get("netAmount").value;
        possalesheaderRecord.noteId = 1;

        if (this.invoiceId && this.invoiceId != 0) {
            // EDIT mode
            possalesheaderRecord.invoiceId = this.invoiceId;
            this.possalesInvoiceService
                .editHeader<possalesheader>(possalesheaderRecord)
                .subscribe(result => {

                    this.AfterSave(result);

                }, error => console.log(error));
        }
        else {
            // ADD NEW mode
            possalesheaderRecord.invoiceId = 0;
            this.possalesInvoiceService
                .addHeader<possalesheader>(possalesheaderRecord)
                .subscribe(result => {

                    this.AfterSave(result);
                }, error => console.log(error));
        }


    }
    DeleteHeader() {
        //var UnitOfMeasurementRecord = (this.unitId) ? this.UnitOfMeasurementRecord : <UnitOfMeasurement>{};
        //UnitOfMeasurementRecord.unitId = this.InvoiceHeaderForm.get("unitId").value;

        //this.unitOfMeasurementService
        //    .delete<UnitOfMeasurement>(UnitOfMeasurementRecord.unitId)
        //    .subscribe(result => {
        //        this.IntalizeScreen()
        //    }, error => console.log(error));
    }
    Navigate(position, value) {
        //this.unitOfMeasurementService
        //    .navigate<UnitOfMeasurement>(position, value)
        //    .subscribe(result => {

        //        this.AfterSave(result);

        //    }, error => console.log(error));
    }
    onDocumentChange(documentId) {
        this.possalesInvoiceService
            .getTypes(documentId)
            .subscribe(result => {

                this.types = result;

            }, error => console.log(error));
    }
    CustomerSelectionChange(customer) {
        this.selectedCustomer = customer;
    }
    ItemSelectionChange(item) {
        this.selectedItem = item;
        this.itemId = this.selectedItem.id;
        this.possalesInvoiceService
            .GetItemUnits(this.selectedItem.id)
            .subscribe(result => {
                this.units = result;
            }, error => console.log(error));

    }
    onUnitChange(unitId) {
        this.possalesInvoiceService
            .GetItemUnitPrice(this.selectedItem.id, unitId)
            .subscribe(result => {
                var itemPrice = 0;
                itemPrice = result;
                this.InvoiceDetailsForm.get("price").setValue(itemPrice);
            }, error => console.log(error));
    }
    onQuantityChangeEvent(event: any) {
        var quantity = event.target.value;
        var price = this.InvoiceDetailsForm.get("price").value;
        var total = quantity * price;
        this.InvoiceDetailsForm.get("totalAmountDetails").setValue(total);
        this.InvoiceDetailsForm.get("netAmountDetails").setValue(total);


    }
    NewDetails() {
        this.detailsId = 0;
        this.InvoiceDetailsForm.reset();
    }
    SaveDetails() {
        var possalesDetailsRecord = (this.detailsId && this.detailsId != 0) ? this.possalesDetailsRecord : <possalesDetails>{};
        possalesDetailsRecord.InvoiceId = this.invoiceId;
        possalesDetailsRecord.ItemId = this.itemId;
        possalesDetailsRecord.UnitId = parseInt(this.InvoiceDetailsForm.get("unitId").value);
        possalesDetailsRecord.Price = parseFloat(this.InvoiceDetailsForm.get("price").value);
        possalesDetailsRecord.Quantity = parseFloat(this.InvoiceDetailsForm.get("quantity").value);
        possalesDetailsRecord.TotalAmount = parseFloat(this.InvoiceDetailsForm.get("totalAmountDetails").value);
        possalesDetailsRecord.NetAmount = parseFloat(this.InvoiceDetailsForm.get("netAmountDetails").value);


        if (this.detailsId && this.detailsId != 0) {
            // EDIT mode
            possalesDetailsRecord.DetailsId = this.detailsId;
            this.possalesInvoiceService
                .editDetails<possalesheader>(possalesDetailsRecord)
                .subscribe(result => {
                    this.AfterSaveDetails(result);
                }, error => console.log(error));
        }
        else {
            // ADD NEW mode
            possalesDetailsRecord.DetailsId = 0;
            this.possalesInvoiceService
                .addDetails<possalesDetails>(possalesDetailsRecord)
                .subscribe(result => {
                    this.AfterSaveDetails(result);
                }, error => console.log(error));
        }
    }

    // #Region Helpers
    private IntalizeScreen() {
        this.invoiceId = 0;
        this.InvoiceHeaderForm.reset();
        this.navigationBarService.IntializeToolbarLookup();
    }
    private AfterSave(result) {
        this.possalesheaderRecord = result;
        this.invoiceId = this.possalesheaderRecord.invoiceId;
        this.InvoiceHeaderForm.patchValue(this.possalesheaderRecord);
        this.navigationBarService.NavigationToolbarLookup();
    }
    private AfterSaveDetails(result) {
        this.selectedItem = null;
        this.optionsItem = null;
        this.itemId = 0;
        this.detailsId = 0;
        this.InvoiceDetailsForm.reset();
    }
    private _filterCustomer(value: string): string[] {
        const filterValue = value.toLowerCase();

        return this.optionsCustomer.filter(option => option.toLowerCase().indexOf(filterValue) === 0);
    }
    private _filterItem(value: string): string[] {
        const filterValue = value.toLowerCase();

        return this.optionsItem.filter(option => option.toLowerCase().indexOf(filterValue) === 0);
    }
    applyFilter(filterValue: string) {
        this.dataSource.filter = filterValue.trim().toLowerCase();
    }

}