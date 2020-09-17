import { Component, OnInit } from '@angular/core';
import {
    FormGroup, FormControl, Validators, FormBuilder,
    AsyncValidatorFn
} from '@angular/forms';
import { CustomValidators } from 'ngx-custom-validators';
import { NavigationBarService } from 'app/views/services/navigation-bar.service'
import { UnitOfMeasurement } from './UnitOfMeasurement';
import { HttpClient } from '@angular/common/http';
import { UnitOfMeasurementService } from 'app/views/POS/lookup/unit-of-measurement/unit-of-measurement.service';
import { BaseFormComponent } from 'app/base.form.component'
import { ActivatedRoute, Router } from '@angular/router';
import { map } from 'rxjs/operators';
import { Observable } from 'rxjs';

@Component({
    selector: 'app-unit-of-measurement',
    templateUrl: './unit-of-measurement.component.html',
    styleUrls: ['./unit-of-measurement.component.scss']
})
export class UnitOfMeasurementComponent extends BaseFormComponent implements OnInit {
    // #Region Common variables
    console = console;
    UnitOfmeasurementForm: FormGroup;
    UnitOfMeasurementRecord: UnitOfMeasurement;
    unitId?: number;

    // #Region Intilize screen
    constructor(private fb: FormBuilder, private navigationBarService: NavigationBarService, private http: HttpClient,
        private unitOfMeasurementService: UnitOfMeasurementService, private router: Router, private activatedRoute: ActivatedRoute) {
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
        this.UnitOfmeasurementForm = this.fb.group({
            unitId: new FormControl({ value: '', disabled: true }),
            unitCode: new FormControl('', [
                Validators.minLength(1),
                Validators.maxLength(10),
                Validators.required
            ]),
            unitEnglishName: new FormControl('', [
                Validators.minLength(1),
                Validators.maxLength(50),
                Validators.required
            ]),
            unitArabicName: new FormControl('', [
                Validators.minLength(1),
                Validators.maxLength(50),
                Validators.required
            ])
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
        this.Navigate("Previous", this.unitId);
    }
    NextRecord() {
        this.Navigate("Next", this.unitId);
    }
    LastRecord() {
        this.Navigate("Last", 0);
    }
    Search() {
        this.Navigate("Search", this.unitId);
    }

    // #Region Main functions
    PageLoad() {
        this.IntalizeScreen();
    }
    SaveHeader() {
        var UnitOfMeasurementRecord = (this.unitId) ? this.UnitOfMeasurementRecord : <UnitOfMeasurement>{};
        UnitOfMeasurementRecord.unitId = this.UnitOfmeasurementForm.get("unitId").value;
        UnitOfMeasurementRecord.unitCode = this.UnitOfmeasurementForm.get("unitCode").value;
        UnitOfMeasurementRecord.unitEnglishName = this.UnitOfmeasurementForm.get("unitEnglishName").value;
        UnitOfMeasurementRecord.unitArabicName = this.UnitOfmeasurementForm.get("unitArabicName").value;

        if (this.unitId || this.unitId !=0) {
            // EDIT mode
            this.unitOfMeasurementService
                .put<UnitOfMeasurement>(UnitOfMeasurementRecord)
                .subscribe(result => {

                    this.AfterSave(result);

                }, error => console.log(error));
        }
        else {
            // ADD NEW mode
            UnitOfMeasurementRecord.unitId = 0;
            this.unitOfMeasurementService
                .post<UnitOfMeasurement>(UnitOfMeasurementRecord)
                .subscribe(result => {

                    this.AfterSave(result);
                }, error => console.log(error));
        }


    }
    DeleteHeader() {
        var UnitOfMeasurementRecord = (this.unitId) ? this.UnitOfMeasurementRecord : <UnitOfMeasurement>{};
        UnitOfMeasurementRecord.unitId = this.UnitOfmeasurementForm.get("unitId").value;

        this.unitOfMeasurementService
            .delete<UnitOfMeasurement>(UnitOfMeasurementRecord.unitId)
            .subscribe(result => {
                this.IntalizeScreen() 
            }, error => console.log(error));
    }
    Navigate(position, value) {
        this.unitOfMeasurementService
            .navigate<UnitOfMeasurement>(position,value)
            .subscribe(result => {

                this.AfterSave(result);

            }, error => console.log(error));
    }

    // #Region Helpers
    private IntalizeScreen() {
        this.unitId = 0;
        this.UnitOfmeasurementForm.reset();
        this.navigationBarService.IntializeToolbarLookup();
    }
    private AfterSave(result) {

        this.UnitOfMeasurementRecord = result;
        this.unitId = this.UnitOfMeasurementRecord.unitId;
        this.UnitOfmeasurementForm.patchValue(this.UnitOfMeasurementRecord);
        this.navigationBarService.NavigationToolbarLookup();
    }

}

