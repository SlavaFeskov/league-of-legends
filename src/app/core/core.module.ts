import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';

import { ContentComponent } from './main-page/content/content.component';
import { LeftSidenavComponent } from './main-page/left-sidenav/left-sidenav.component';
import { MainPageComponent } from './main-page/main-page.component';

@NgModule({
  declarations: [
    MainPageComponent,
    LeftSidenavComponent,
    ContentComponent
  ],
  imports: [
    CommonModule,
    SharedModule
  ],
  exports: [
    MainPageComponent
  ]
})
export class CoreModule { }
