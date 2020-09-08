import { Routes } from '@angular/router';

import { UnitOfMeasurementComponent } from './unit-of-measurement/unit-of-measurement.component';
 

export const LookupRoutes: Routes = [
    {
        path: '',
        children: [{
            path: 'UnitOfMeasurement',
            component: UnitOfMeasurementComponent,
            data: { title: 'UnitOfMeasurement', breadcrumb: 'UnitOfMeasurement' }
        } ]
    }
];
