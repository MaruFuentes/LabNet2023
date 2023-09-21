import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { ShipperslistComponent } from './components/shipperslist/shipperslist.component';
import { ShipperscreateComponent } from './components/shipperscreate/shipperscreate.component';
import { ShippersupdateComponent } from './components/shippersupdate/shippersupdate.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { SharedModule } from 'src/app/shared/shared.module';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';

export const routes: Routes = [{
  path: '',
  component: ShipperslistComponent
}, {
  path: 'create',
  component: ShipperscreateComponent
}, {
  path: 'update/:id',
  component: ShippersupdateComponent
}, {
  path: '**',
  pathMatch: 'full',
  redirectTo: ''
}]

@NgModule({
  declarations: [
    ShipperslistComponent,
    ShipperscreateComponent,
    ShippersupdateComponent
  ],
  imports: [
  CommonModule,
    RouterModule.forChild(routes),
    ReactiveFormsModule,
    SharedModule,
    FormsModule,
    FontAwesomeModule
  ]
})
export class ShippersModule { }
