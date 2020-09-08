"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.SharedPagesRoutes = void 0;
var dashboard_component_1 = require("./dashboard/dashboard.component");
exports.SharedPagesRoutes = [
    {
        path: '',
        children: [{
                path: 'Dashboard',
                component: dashboard_component_1.DashboardComponent,
                data: { title: 'Dashboard', breadcrumb: 'Dashboard' }
            }]
    }
];
//# sourceMappingURL=sharedpages.routing.js.map