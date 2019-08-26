import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';

import { ContentComponent } from './main-page/content/content.component';
import { LeftSidenavComponent } from './main-page/left-sidenav/left-sidenav.component';
import { MainPageComponent } from './main-page/main-page.component';
import { TreeListComponent } from './main-page/tree-list/tree-list.component';
import { TreeListItemComponent } from './main-page/tree-list-item/tree-list-item.component';

@NgModule({
  declarations: [
    MainPageComponent,
    LeftSidenavComponent,
    ContentComponent,
    TreeListComponent,
    TreeListItemComponent
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
