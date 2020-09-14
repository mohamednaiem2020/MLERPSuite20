"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.rootRouterConfig = void 0;
var admin_layout_component_1 = require("./shared/components/layouts/admin-layout/admin-layout.component");
var auth_layout_component_1 = require("./shared/components/layouts/auth-layout/auth-layout.component");
var auth_guard_1 = require("./shared/guards/auth.guard");
exports.rootRouterConfig = [
    {
        path: '',
        redirectTo: 'Sharedpages/Dashboard',
        pathMatch: 'full'
    },
    {
        path: '',
        component: auth_layout_component_1.AuthLayoutComponent,
        children: [
            {
                path: 'sessions',
                loadChildren: function () { return Promise.resolve().then(function () { return require('./views/sessions/sessions.module'); }).then(function (m) { return m.SessionsModule; }); },
                data: { title: 'Session' }
            }
        ]
    },
    {
        path: '',
        component: admin_layout_component_1.AdminLayoutComponent,
        canActivate: [auth_guard_1.AuthGuard],
        children: [
            {
                path: 'others',
                loadChildren: function () { return Promise.resolve().then(function () { return require('./views/others/others.module'); }).then(function (m) { return m.OthersModule; }); },
                data: { title: 'Others', breadcrumb: 'OTHERS' }
            },
            {
                path: 'Lookup',
                loadChildren: function () { return Promise.resolve().then(function () { return require('./views/POS/Lookup/lookup.module'); }).then(function (m) { return m.LookupModule; }); },
                data: { title: 'Lookup', breadcrumb: 'Lookup' }
            },
            {
                path: 'Sharedpages',
                loadChildren: function () { return Promise.resolve().then(function () { return require('./views/sharedpages/sharedpages.module'); }).then(function (m) { return m.SharedpagesModule; }); },
                data: { title: 'Sharedpages', breadcrumb: 'Sharedpages' }
            },
            {
                path: 'services',
                loadChildren: function () { return Promise.resolve().then(function () { return require('./views/services/services.module'); }).then(function (m) { return m.ServicesModule; }); },
                data: { title: 'services', breadcrumb: 'services' }
            },
            {
                path: 'search',
                loadChildren: function () { return Promise.resolve().then(function () { return require('./views/search-view/search-view.module'); }).then(function (m) { return m.SearchViewModule; }); }
            }
        ]
    },
    {
        path: '**',
        redirectTo: 'sessions/404'
    }
];
//# sourceMappingURL=app.routing.js.map