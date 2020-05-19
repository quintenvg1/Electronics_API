import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { NavbarComponent } from './navbar/navbar.component';
import { DeviceAddComponent } from './device-add/device-add.component';
import { DeviceListComponent } from './device-list/device-list.component';


const routes: Routes = [
  { path: 'navbar', component: NavbarComponent },
  { path: 'create', component: DeviceAddComponent }, //route to the device add form
  { path: "list", component: DeviceListComponent},

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
