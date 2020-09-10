import { Component } from '@angular/core';
import { NavigationBarService } from 'app/views/services/navigation-bar.service' 

@Component({
    selector: 'app-navigation-bar',
    templateUrl: './navigation-bar.component.html',
    styleUrls: ['./navigation-bar.component.scss']
})
/** NavigationBar component*/
export class NavigationBarComponent {
    /** NavigationBar ctor */
    constructor(private navigationBarService: NavigationBarService   ) {
        
    }

    New() {
        this.navigationBarService.onNewClick();
    }  

    
}