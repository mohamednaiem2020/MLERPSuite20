import { Component, OnInit } from '@angular/core';
import {
    FormGroup, FormControl, Validators, FormBuilder,
    AsyncValidatorFn
} from '@angular/forms';
import { CustomValidators } from 'ngx-custom-validators';
import { NavigationBarService } from 'app/views/services/navigation-bar.service'
//import { UnitOfMeasurement } from './UnitOfMeasurement';
import { HttpClient } from '@angular/common/http';
//import { UnitOfMeasurementService } from 'app/views/POS/lookup/unit-of-measurement/unit-of-measurement.service';
import { BaseFormComponent } from 'app/base.form.component'
import { ActivatedRoute, Router } from '@angular/router';
import { map } from 'rxjs/operators';
import { Observable } from 'rxjs';

@Component({
    selector: 'app-possales-invoice',
    templateUrl: './possales-invoice.component.html',
    styleUrls: ['./possales-invoice.component.scss']
})
/** POSSalesInvoice component*/
export class PossalesInvoiceComponent extends BaseFormComponent implements OnInit {
    /** POSSalesInvoice ctor */
    // #Region Common variables
    console = console;
    InvoiceHeaderForm: FormGroup;
    InvoiceDetailsForm: FormGroup;
    //UnitOfMeasurementRecord: UnitOfMeasurement;
    invoiceId?: number;

    // #Region Intilize screen
    constructor(private fb: FormBuilder, private navigationBarService: NavigationBarService, private http: HttpClient,
        //private unitOfMeasurementService: UnitOfMeasurementService,
        private router: Router, private activatedRoute: ActivatedRoute) {
        super();
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
            totalAmount: new FormControl('', Validators.required),
            netAmount: new FormControl('', Validators.required),
            note: new FormControl(''),
        })

        this.InvoiceDetailsForm = this.fb.group({
            detailsId: new FormControl({ value: '', disabled: true }),
            itemId: new FormControl('', Validators.required),
            unitId: new FormControl('', Validators.required),
            quantity: new FormControl('', Validators.required),
            price: new FormControl('', Validators.required),
            totalAmount: new FormControl(''),
            netAmount: new FormControl(''),
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
        //var UnitOfMeasurementRecord = (this.unitId) ? this.UnitOfMeasurementRecord : <UnitOfMeasurement>{};
        //UnitOfMeasurementRecord.unitId = this.InvoiceHeaderForm.get("unitId").value;
        //UnitOfMeasurementRecord.unitCode = this.InvoiceHeaderForm.get("unitCode").value;
        //UnitOfMeasurementRecord.unitEnglishName = this.InvoiceHeaderForm.get("unitEnglishName").value;
        //UnitOfMeasurementRecord.unitArabicName = this.InvoiceHeaderForm.get("unitArabicName").value;

        //if (this.unitId || this.unitId != 0) {
        //    // EDIT mode
        //    this.unitOfMeasurementService
        //        .edit<UnitOfMeasurement>(UnitOfMeasurementRecord)
        //        .subscribe(result => {

        //            this.AfterSave(result);

        //        }, error => console.log(error));
        //}
        //else {
        //    // ADD NEW mode
        //    UnitOfMeasurementRecord.unitId = 0;
        //    this.unitOfMeasurementService
        //        .add<UnitOfMeasurement>(UnitOfMeasurementRecord)
        //        .subscribe(result => {

        //            this.AfterSave(result);
        //        }, error => console.log(error));
        //}


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

    // #Region Helpers
    private IntalizeScreen() {
        //this.unitId = 0;
        //this.InvoiceHeaderForm.reset();
        //this.navigationBarService.IntializeToolbarLookup();
    }
    private AfterSave(result) {

        //this.UnitOfMeasurementRecord = result;
        //this.unitId = this.UnitOfMeasurementRecord.unitId;
        //this.InvoiceHeaderForm.patchValue(this.UnitOfMeasurementRecord);
        //this.navigationBarService.NavigationToolbarLookup();
    }
}