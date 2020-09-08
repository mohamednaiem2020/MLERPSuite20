"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.sharedcomponentsRoutes = void 0;
var main_board_component_1 = require("./main-board/main-board.component");
exports.sharedcomponentsRoutes = [
    {
        path: '',
        children: [
            {
                path: 'MainBoard',
                component: main_board_component_1.MainBoardComponent,
                data: { title: 'MainBoard', breadcrumb: 'MainBoard' }
            }
        ]
    }
];
//# sourceMappingURL=sharedcomponents.routing.js.map