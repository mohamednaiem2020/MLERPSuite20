"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.LookupRoutes = void 0;
var unit_of_measurement_component_1 = require("./unit-of-measurement/unit-of-measurement.component");
exports.LookupRoutes = [
    {
        path: '',
        children: [{
                path: 'UnitOfMeasurement',
                component: unit_of_measurement_component_1.UnitOfMeasurementComponent,
                data: { title: 'UnitOfMeasurement', breadcrumb: 'UnitOfMeasurement' }
            }]
    }
];
//# sourceMappingURL=Lookup.routing.js.map