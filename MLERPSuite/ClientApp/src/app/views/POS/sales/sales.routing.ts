import { Routes } from '@angular/router';

import { PossalesInvoiceComponent } from './possales-invoice/possales-invoice.component'
 

export const SalesRoutes: Routes = [
    {
        path: '',
        children: [{
            path: 'PossalesInvoice',
            component: PossalesInvoiceComponent,
            data: { title: 'PossalesInvoice', breadcrumb: 'PossalesInvoice' }
        } ]
    }
];
