import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { DeviceAddComponent } from './device-add/device-add.component';
import { HttpClientModule } from '@angular/common/http';
import { DeviceListComponent } from './device-list/device-list.component';
import { DeviceRemoveComponent } from './device-remove/device-remove.component';
import { DevicepageComponent } from './devicepage/devicepage.component';
import { ManufacturorpageComponent } from './manufacturorpage/manufacturorpage.component';
import { ManufacturorCreateComponent } from './manufacturor-create/manufacturor-create.component';
import { ManufacturorListComponent } from './manufacturor-list/manufacturor-list.component';
import { ManufacturorRemoveComponent } from './manufacturor-remove/manufacturor-remove.component';
import { ManufacturorUpdateComponent } from './manufacturor-update/manufacturor-update.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    DeviceAddComponent,
    DeviceListComponent,
    DeviceRemoveComponent,
    DevicepageComponent,
    ManufacturorpageComponent,
    ManufacturorCreateComponent,
    ManufacturorListComponent,
    ManufacturorRemoveComponent,
    ManufacturorUpdateComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
