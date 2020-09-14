import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { CustomValidators } from 'ngx-custom-validators';
import { NavigationBarService } from 'app/views/services/navigation-bar.service'
import { UnitOfMeasurement } from './UnitOfMeasurement';
import { HttpClient } from '@angular/common/http';
import { UnitOfMeasurementService } from 'app/views/POS/lookup/unit-of-measurement/unit-of-measurement.service';
import { BaseFormComponent } from 'app/base.form.component'
import { ActivatedRoute, Router } from '@angular/router';

@Component({
    selector: 'app-unit-of-measurement',
    templateUrl: './unit-of-measurement.component.html',
    styleUrls: ['./unit-of-measurement.component.scss']
})
export class UnitOfMeasurementComponent extends BaseFormComponent implements OnInit {
    // #Region Common variables
    formData = {}
    console = console;
    UnitOfmeasurementForm: FormGroup;
    UnitOfMeasurementRecord: UnitOfMeasurement;
    unitId?: number;

    // #Region Intilize screen
    constructor(private navigationBarService: NavigationBarService, private http: HttpClient,
        private unitOfMeasurementService: UnitOfMeasurementService, private router: Router) {
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
        this.UnitOfmeasurementForm = new FormGroup({
            UnitId: new FormControl({ value: '', disabled: true }),
            UnitCode: new FormControl('', [
                Validators.minLength(1),
                Validators.maxLength(10),
                Validators.required
            ]),
            UnitEnglishName: new FormControl('', [
                Validators.minLength(1),
                Validators.maxLength(50),
                Validators.required
            ]),
            UnitArabicName: new FormControl('', [
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
        alert('Delete button clicked');
    }
    FirstRecord() {
        alert('FirstRecord button clicked');
    }
    PreviousRecord() {
        alert('PreviousRecord button clicked');
    }
    NextRecord() {
        alert('NextRecord button clicked');
    }
    LastRecord() {
        alert('LastRecord button clicked');
    }
    Search() {
        alert('Search button clicked');
    }

    // #Region Main functions
    PageLoad() {
        this.IntalizeScreen();
    }
    SaveHeader() {
        var UnitOfMeasurementRecord = (this.unitId) ? this.UnitOfMeasurementRecord : <UnitOfMeasurement>{};
        UnitOfMeasurementRecord.UnitId = this.UnitOfmeasurementForm.get("UnitId").value;
        UnitOfMeasurementRecord.UnitCode = this.UnitOfmeasurementForm.get("UnitCode").value;
        UnitOfMeasurementRecord.UnitEnglishName = this.UnitOfmeasurementForm.get("UnitEnglishName").value;
        UnitOfMeasurementRecord.UnitArabicName = this.UnitOfmeasurementForm.get("UnitArabicName").value;

        if (this.unitId) {
            // EDIT mode
            this.unitOfMeasurementService
                .put<UnitOfMeasurement>(UnitOfMeasurementRecord)
                .subscribe(result => {
                    this.AfterSave(UnitOfMeasurementRecord.UnitId);

                }, error => console.log(error));
        }
        else {
            // ADD NEW mode
            UnitOfMeasurementRecord.UnitId = 0;
            this.unitOfMeasurementService
                .post<UnitOfMeasurement>(UnitOfMeasurementRecord)
                .subscribe(result => {
                    this.AfterSave(UnitOfMeasurementRecord.UnitId);
                }, error => console.log(error));
        }


    }


    // #Region Helpers
    private IntalizeScreen() {
        this.navigationBarService.IntializeToolbarLookup();
    }
    private AfterSave(unitId) {
        alert("UnitOfMeasurement " + unitId + " has been updated.");
        this.navigationBarService.NavigationToolbarLookup();
    }

}

