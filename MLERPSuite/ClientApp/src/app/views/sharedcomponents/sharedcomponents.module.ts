import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatChipsModule } from '@angular/material/chips';
import { MatExpansionModule } from '@angular/material/expansion';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatIconModule } from '@angular/material/icon';
import { MatListModule } from '@angular/material/list';
import { MatMenuModule } from '@angular/material/menu';
import { MatProgressBarModule } from '@angular/material/progress-bar';
import { MatTableModule } from '@angular/material/table';
import { MatTabsModule } from '@angular/material/tabs';
import { RouterModule } from '@angular/router';
import { FlexLayoutModule } from '@angular/flex-layout';
import { ChartsModule } from 'ng2-charts';
import { NgxEchartsModule } from 'ngx-echarts';
import * as echarts from 'echarts';

import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { SharedPipesModule } from 'app/shared/pipes/shared-pipes.module';


import { sharedcomponentsRoutes } from './Sharedcomponents.routing';
import { NavigationBarComponent } from './navigation-bar/navigation-bar.component';
import { MainBoardComponent } from './main-board/main-board.component';



@NgModule({
    imports: [
        CommonModule,
        MatIconModule,
        MatCardModule,
        MatMenuModule,
        MatProgressBarModule,
        MatExpansionModule,
        MatButtonModule,
        MatChipsModule,
        MatListModule,
        MatTabsModule,
        MatTableModule,
        MatGridListModule,
        FlexLayoutModule,
        ChartsModule,
        NgxEchartsModule.forRoot({
            echarts
        }),
        NgxDatatableModule,
        SharedPipesModule,
        RouterModule.forChild(sharedcomponentsRoutes)
    ],
    declarations: [NavigationBarComponent, MainBoardComponent],
    
})
export class SharedcomponentsModule { }