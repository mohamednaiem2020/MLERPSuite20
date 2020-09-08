import { Routes } from '@angular/router';

import { MainBoardComponent } from './main-board/main-board.component';

export const sharedcomponentsRoutes: Routes = [
    {
        path: '',
        children: [
            
            {
                path: 'MainBoard',
                component: MainBoardComponent,
                data: { title: 'MainBoard', breadcrumb: 'MainBoard' }
            } ]
    }
];
