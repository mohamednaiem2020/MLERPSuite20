import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatNativeDateModule } from '@angular/material/core';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatIconModule } from '@angular/material/icon';
import { MatInputModule } from '@angular/material/input';
import { MatListModule } from '@angular/material/list';
import { MatProgressBarModule } from '@angular/material/progress-bar';
import { MatRadioModule } from '@angular/material/radio';
import { MatStepperModule } from '@angular/material/stepper';
import { FlexLayoutModule } from '@angular/flex-layout';
import { QuillModule } from 'ngx-quill';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { FileUploadModule } from 'ng2-file-upload';
import { SharedpagesModule } from 'app/views/sharedpages/sharedpages.module';

import { UnitOfMeasurementComponent } from './unit-of-measurement/unit-of-measurement.component';
import { LookupRoutes } from './Lookup.routing';
import { UnitOfMeasurementService } from 'app/views/POS/lookup/unit-of-measurement/unit-of-measurement.service'
 

@NgModule({
    imports: [
        CommonModule,
        FormsModule,
        ReactiveFormsModule,
        MatInputModule,
        MatListModule,
        MatCardModule,
        MatDatepickerModule,
        MatNativeDateModule,
        MatProgressBarModule,
        MatRadioModule,
        MatCheckboxModule,
        MatButtonModule,
        MatIconModule,
        MatStepperModule,
        FlexLayoutModule,
        QuillModule,
        NgxDatatableModule,
        FileUploadModule,
        RouterModule.forChild(LookupRoutes), SharedpagesModule
    ],
    declarations: [UnitOfMeasurementComponent
        
    ],
    providers: [UnitOfMeasurementService]
})
export class LookupModule { }
