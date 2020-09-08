import { Routes } from '@angular/router';
import { AdminLayoutComponent } from './shared/components/layouts/admin-layout/admin-layout.component';
import { AuthLayoutComponent } from './shared/components/layouts/auth-layout/auth-layout.component';
import { AuthGuard } from './shared/guards/auth.guard';

export const rootRouterConfig: Routes = [
   
    {
        path: '',
        redirectTo: 'sharedcomponents/MainBoard',
        pathMatch: 'full'
    },
  {
    path: '', 
    component: AuthLayoutComponent,
    children: [
      { 
        path: 'sessions', 
        loadChildren: () => import('./views/sessions/sessions.module').then(m => m.SessionsModule),
        data: { title: 'Session'} 
      }
    ]
  },
  {
    path: '', 
    component: AdminLayoutComponent,
    canActivate: [AuthGuard],
    children: [
      {
        path: 'others', 
        loadChildren: () => import('./views/others/others.module').then(m => m.OthersModule), 
        data: { title: 'Others', breadcrumb: 'OTHERS'}
        },
        {
            path: 'Lookup',
            loadChildren: () => import('./views/POS/Lookup/lookup.module').then(m => m.LookupModule),
            data: { title: 'Lookup', breadcrumb: 'Lookup' }
        }
        ,
        {
            path: 'sharedcomponents',
            loadChildren: () => import('./views/sharedcomponents/sharedcomponents.module').then(m => m.SharedcomponentsModule),
            data: { title: 'sharedcomponents', breadcrumb: 'sharedcomponents' }
        }
        ,
         
      {
        path: 'search', 
        loadChildren: () => import('./views/search-view/search-view.module').then(m => m.SearchViewModule)
      }
    ]
  },
  { 
    path: '**', 
    redirectTo: 'sessions/404'
  }
];

