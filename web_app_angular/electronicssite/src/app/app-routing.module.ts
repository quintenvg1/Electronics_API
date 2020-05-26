import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { NavbarComponent } from './navbar/navbar.component';
import { DeviceAddComponent } from './device-add/device-add.component';
import { DeviceListComponent } from './device-list/device-list.component';
import { DeviceRemoveComponent } from './device-remove/device-remove.component';
import { DevicepageComponent } from './devicepage/devicepage.component';
import { ManufacturorpageComponent } from './manufacturorpage/manufacturorpage.component';
import { ManufacturorCreateComponent } from './manufacturor-create/manufacturor-create.component';
import { ManufacturorListComponent } from './manufacturor-list/manufacturor-list.component';
import { ManufacturorRemoveComponent } from './manufacturor-remove/manufacturor-remove.component';
import { ManufacturorUpdateComponent } from './manufacturor-update/manufacturor-update.component';


const routes: Routes = [
  { path: "navbar", component: NavbarComponent },
  { path: "create", component: DeviceAddComponent },
  { path: "list", component: DeviceListComponent },
  { path: "remove", component: DeviceRemoveComponent  },
  { path: "devicepage", component: DevicepageComponent },
  { path: "manufacturorpage", component: ManufacturorpageComponent},
  { path: "createM", component: ManufacturorCreateComponent },
  { path: "listM", component: ManufacturorListComponent },
  { path: "removeM", component: ManufacturorRemoveComponent },
  { path: "updateM", component: ManufacturorUpdateComponent },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
