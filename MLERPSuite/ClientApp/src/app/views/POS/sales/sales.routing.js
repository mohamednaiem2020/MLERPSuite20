"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.SalesRoutes = void 0;
var possales_invoice_component_1 = require("./possales-invoice/possales-invoice.component");
exports.SalesRoutes = [
    {
        path: '',
        children: [{
                path: 'PossalesInvoice',
                component: possales_invoice_component_1.PossalesInvoiceComponent,
                data: { title: 'PossalesInvoice', breadcrumb: 'PossalesInvoice' }
            }]
    }
];
//# sourceMappingURL=sales.routing.js.map