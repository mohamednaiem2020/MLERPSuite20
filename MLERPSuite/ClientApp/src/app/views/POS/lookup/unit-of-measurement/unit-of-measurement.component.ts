import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { CustomValidators } from 'ngx-custom-validators';

@Component({
  selector: 'app-unit-of-measurement',
  templateUrl: './unit-of-measurement.component.html',
  styleUrls: ['./unit-of-measurement.component.scss']
})
export class UnitOfMeasurementComponent implements OnInit {
    formData = {}
    console = console;
    UnitOfmeasurement: FormGroup;

  constructor() { }

    ngOnInit() {
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

}
