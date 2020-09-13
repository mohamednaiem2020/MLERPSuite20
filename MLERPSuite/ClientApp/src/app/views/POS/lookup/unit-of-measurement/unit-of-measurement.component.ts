import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { CustomValidators } from 'ngx-custom-validators';
import { NavigationBarService } from 'app/views/services/navigation-bar.service'

@Component({
    selector: 'app-unit-of-measurement',
    templateUrl: './unit-of-measurement.component.html',
    styleUrls: ['./unit-of-measurement.component.scss']
})
export class UnitOfMeasurementComponent implements OnInit {
    formData = {}
    console = console;
    UnitOfmeasurement: FormGroup;

    constructor(private navigationBarService: NavigationBarService) { }

    ngOnInit() {
        if (this.navigationBarService.subsVarOut == undefined) {
            this.navigationBarService.subsVarOut = this.navigationBarService.
                invokeHandler.subscribe((name: string) => {
                    if (name == "New")
                        this.New();
                    else if (name == "Save")
                        this.Save();
                    else if (name == "Delete")
                        this.Delete();
                    else if (name == "Process")
                        this.Process();
                    else if (name == "Cancel")
                        this.Cancel();
                    else if (name == "UndoProcess")
                        this.UndoProcess();
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
                    else if (name == "LockUnlock")
                        this.LockUnlock();
                    else if (name == "Copy")
                        this.Copy();
                    else if (name == "Download")
                        this.Download();
                    else if (name == "Upload")
                        this.Upload();
                    else if (name == "PageLoad")
                        this.PageLoad();
                });
        }

     

        this.UnitOfmeasurement = new FormGroup({
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
    PageLoad() {
        this.navigationBarService.IntializeToolbarLookup();
    }
    New() {
        this.navigationBarService.IntializeToolbarLookup();
    }
    Save() {
        this.SaveHeader();
    }
    Delete() {
        alert('Delete button clicked');
    }
    Process() {
        alert('Process button clicked');
    }
    Cancel() {
        alert('Cancel button clicked');
    }
    UndoProcess() {
        alert('UndoProcess button clicked');
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
    LockUnlock() {
        alert('LockUnlock button clicked');
    }
    Copy() {
        alert('Copy button clicked');
    }
    Download() {
        alert('Download button clicked');
    }
    Upload() {
        alert('Upload button clicked');
    }

    SaveHeader() {

    }
}
