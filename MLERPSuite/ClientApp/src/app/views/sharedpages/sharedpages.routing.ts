import { Routes } from '@angular/router';

import { DashboardComponent } from './dashboard/dashboard.component';
 

export const SharedPagesRoutes: Routes = [
    {
        path: '',
        children: [{
            path: 'Dashboard',
            component: DashboardComponent,
            data: { title: 'Dashboard', breadcrumb: 'Dashboard' }
        } ]
    }
];
