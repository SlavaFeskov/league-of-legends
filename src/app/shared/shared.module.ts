import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { MatToolbarModule } from '@angular/material/toolbar';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatExpansionModule } from '@angular/material/expansion';
import { MatTreeModule } from '@angular/material/tree';
import { MatIconModule } from '@angular/material/icon';
import { MatDividerModule } from '@angular/material/divider';
import { MatListModule } from '@angular/material/list';
import { AppRoutingModule } from '../app-routing.module';

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    BrowserAnimationsModule,
    MatToolbarModule,
    MatExpansionModule,
    AppRoutingModule
  ],
  exports: [
    BrowserAnimationsModule,
    MatToolbarModule,
    MatSidenavModule,
    MatExpansionModule,
    MatTreeModule,
    MatIconModule,
    MatDividerModule,
    MatListModule,
    AppRoutingModule
  ]
})
export class SharedModule { }
