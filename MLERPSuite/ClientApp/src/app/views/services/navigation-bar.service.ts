import { Injectable, EventEmitter } from '@angular/core';
import { Subscription } from 'rxjs/internal/Subscription';    

@Injectable({
    providedIn: 'root'
})
export class NavigationBarService {
    invokeNew = new EventEmitter();
    subsVar: Subscription;

    constructor() { }

    onNewClick() {
        this.invokeNew.emit();
    }   
}