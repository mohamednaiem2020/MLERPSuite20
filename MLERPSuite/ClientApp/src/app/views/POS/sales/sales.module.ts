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
import { MatAutocompleteModule } from '@angular/material/autocomplete';
import { PossalesInvoiceComponent } from './possales-invoice/possales-invoice.component'
import { SalesRoutes } from './sales.routing'
import { PossalesInvoiceService } from 'app/views/POS/sales/possales-invoice/possales-invoice.service';
import { MatSortModule } from '@angular/material/sort';
import { MatTableModule } from '@angular/material/table';


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
        MatAutocompleteModule,
        RouterModule.forChild(SalesRoutes), SharedpagesModule,
        MatSortModule,
        MatTableModule,
    ],
    declarations: [PossalesInvoiceComponent

    ],
    providers: [PossalesInvoiceService]
})
export class SalesModule { }
