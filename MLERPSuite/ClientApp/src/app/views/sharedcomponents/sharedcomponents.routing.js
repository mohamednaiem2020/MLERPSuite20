"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.sharedcomponentsRoutes = void 0;
var navigation_bar_component_1 = require("./navigation-bar/navigation-bar.component");
var main_board_component_1 = require("./main-board/main-board.component");
exports.sharedcomponentsRoutes = [
    {
        path: '',
        children: [
            {
                path: 'NavigationBar',
                component: navigation_bar_component_1.NavigationBarComponent,
                data: { title: 'NavigationBar', breadcrumb: 'NavigationBar' }
            },
            {
                path: 'MainBoard',
                component: main_board_component_1.MainBoardComponent,
                data: { title: 'MainBoard', breadcrumb: 'MainBoard' }
            }
        ]
    }
];
//# sourceMappingURL=sharedcomponents.routing.js.map