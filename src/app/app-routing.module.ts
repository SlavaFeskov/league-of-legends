import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LeftSidenavComponent } from '@core/main-page/left-sidenav/left-sidenav.component';


const routes: Routes = [
  {
    path: 'test', component: LeftSidenavComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
