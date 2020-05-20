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

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    DeviceAddComponent,
    DeviceListComponent,
    DeviceRemoveComponent
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
