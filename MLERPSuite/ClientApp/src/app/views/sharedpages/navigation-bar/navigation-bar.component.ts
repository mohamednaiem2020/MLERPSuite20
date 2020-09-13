import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { NavigationBarService } from 'app/views/services/navigation-bar.service' 

@Component({
    selector: 'app-navigation-bar',
    templateUrl: './navigation-bar.component.html',
    styleUrls: ['./navigation-bar.component.scss']
})
/** NavigationBar component*/
export class NavigationBarComponent implements OnInit {
    IntializedLookupDisabled: boolean = false;
    /** NavigationBar ctor */
    constructor(private navigationBarService: NavigationBarService   ) {
        
    }

   

    ngOnInit() {
        if (this.navigationBarService.subsVarIn == undefined) {
            this.navigationBarService.subsVarIn = this.navigationBarService.
                invokeHandler.subscribe((name: string) => {
                    if (name == "IntializeToolbarLookup")
                        this.IntializeToolbarLookup();
                });
        }

        this.navigationBarService.PageLoad();

    }

    New() {
        //this.IntializedLookupDisabled = true;
        this.navigationBarService.onNewClick();
    } 
    Save() {
        this.navigationBarService.onSaveClick();
    } 
    Delete() {
        this.navigationBarService.onDeleteClick();
    } 
    Process() {
        this.navigationBarService.onProcessClick();
    } 
    Cancel() {
        this.navigationBarService.onCancelClick();
    } 
    UndoProcess() {
        this.navigationBarService.onUndoProcessClick();
    } 
    FirstRecord() {
        this.navigationBarService.onFirstRecordClick();
    } 
    PreviousRecord() {
        this.navigationBarService.onPreviousRecordClick();
    } 
    NextRecord() {
        this.navigationBarService.onNextRecordClick();
    } 
    LastRecord() {
        this.navigationBarService.onLastRecordClick();
    } 
    Search() {
        this.navigationBarService.onSearchClick();
    } 
    LockUnlock() {
        this.navigationBarService.onLockUnlockClick();
    } 
    Copy() {
        this.navigationBarService.onCopyClick();
    } 
    Download() {
        this.navigationBarService.onDownloadClick();
    } 
    Upload() {
        this.navigationBarService.onUploadClick();
    } 
    IntializeToolbarLookup() {
        this.IntializedLookupDisabled = true;
    } 
     
}