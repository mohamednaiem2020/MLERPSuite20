import { Injectable, EventEmitter } from '@angular/core';
import { Subscription } from 'rxjs/internal/Subscription';    

@Injectable({
    providedIn: 'root'
})
export class NavigationBarService {
    invokeHandler = new EventEmitter();
    subsVarOut: Subscription;
    subsVarIn: Subscription;

    constructor() { }

    onNewClick() {
        this.invokeHandler.emit("New");
    }  
    onSaveClick() {
        this.invokeHandler.emit("Save");
    }  
    onDeleteClick() {
        this.invokeHandler.emit("Delete");
    }  
    onProcessClick() {
        this.invokeHandler.emit("Process");
    }  
    onCancelClick() {
        this.invokeHandler.emit("Cancel");
    }  
    onUndoProcessClick() {
        this.invokeHandler.emit("UndoProcess");
    }  
    onFirstRecordClick() {
        this.invokeHandler.emit("FirstRecord");
    }  
    onPreviousRecordClick() {
        this.invokeHandler.emit("PreviousRecord");
    }  
    onNextRecordClick() {
        this.invokeHandler.emit("NextRecord");
    }  
    onLastRecordClick() {
        this.invokeHandler.emit("LastRecord");
    }  
    onSearchClick() {
        this.invokeHandler.emit("Search");
    }  
    onLockUnlockClick() {
        this.invokeHandler.emit("LockUnlock");
    }  
    onCopyClick() {
        this.invokeHandler.emit("Copy");
    }  
    onDownloadClick() {
        this.invokeHandler.emit("Download");
    }  
    onUploadClick() {
        this.invokeHandler.emit("Upload");
    } 
    IntializeToolbarLookup() {
        this.invokeHandler.emit("IntializeToolbarLookup");
    } 

}