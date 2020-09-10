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

    constructor(private navigationBarService: NavigationBarService ) { }

    ngOnInit() {
        if (this.navigationBarService.subsVar == undefined) {
            this.navigationBarService.subsVar = this.navigationBarService.
                invokeNew.subscribe((name: string) => {
                    this.New();
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

    New() {
        alert('new button clicked');
    } 
}
