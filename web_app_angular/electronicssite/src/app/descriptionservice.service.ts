import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class DescriptionserviceService {

  token = "32df285046f2de57600b43a4514ba3820c782093e17a22b4";
  url = "https://fonoapi.freshpixl.com/v1/";
  baseurl = "https://fonoapi.freshpixl.com/v1/getdevice?token=32df285046f2de57600b43a4514ba3820c782093e17a22b4&device=";
  
  constructor(private client: HttpClient) {
   }

  getdescription(devicename:string){
    return this.client.get<description>(this.baseurl + devicename.toString());
  }
}
export interface description{
  DeviceName: string,
  technology: string,
  dimensions: string,
  size: string,
  battery_c: string,
  cpu: string,
  gpu: string,
  chipset: string,
}
