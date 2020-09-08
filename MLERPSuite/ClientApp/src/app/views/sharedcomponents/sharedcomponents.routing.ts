import { Routes } from '@angular/router';

import { NavigationBarComponent } from './navigation-bar/navigation-bar.component';
import { MainBoardComponent } from './main-board/main-board.component';

export const sharedcomponentsRoutes: Routes = [
    {
        path: '',
        children: [
            {
                path: 'NavigationBar',
                component: NavigationBarComponent,
                data: { title: 'NavigationBar', breadcrumb: 'NavigationBar' }
            },
            {
                path: 'MainBoard',
                component: MainBoardComponent,
                data: { title: 'MainBoard', breadcrumb: 'MainBoard' }
            } ]
    }
];
