import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ServicesRoutes } from './services.routing';
import { RouterModule } from '@angular/router';
import { NavigationBarService } from './navigation-bar.service'

@NgModule({
  declarations: [],
  imports: [
      CommonModule,
      RouterModule.forChild(ServicesRoutes)
    ],
    providers: [NavigationBarService]
})
export class ServicesModule { }
