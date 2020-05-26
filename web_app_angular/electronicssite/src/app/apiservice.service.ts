import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';



@Injectable({
  providedIn: 'root'
})
export class ApiserviceService {

  private baseurl_device: string = "https://localhost:44364/api/device";
  private baseurl_manufacturor: string = "https://localhost:44364/api/manufacturors";
  private baseurl_authorisation: string = "https://localhost:44364/api/basicauth";


  constructor(private client:HttpClient) { 
    }
  
  checkAuthorisation(){
    return this.client.get("https://localhost:44364/api/basicauth");
  }
 
  postdevice(newdevice:Device){
    return this.client.post<Device>(this.baseurl_device, newdevice);
  }

  getDeviceList(){
    return this.client.get<IDevice>(this.baseurl_device + "/list");
  }

  getspecificDevices(bymanufacturor:number){
    return this.client.get<IDevice>(this.baseurl_device + "/list/" + bymanufacturor);
  }

  removespecificDevice(byID:number){
    return this.client.delete<IfindDevice>(this.baseurl_device+"/"+ byID); //automatically finds the method to delete
  }

  GetManufacturorList(){
    return this.client.get<Manufaturor>(this.baseurl_manufacturor + "/list");
  }

  GetspecificManufacturor(ID:number){
    return this.client.get<Manufaturor>(this.baseurl_manufacturor + "/list/" + ID);
  }

  AddnewManufacturor(newmanufacturor:Manufaturor){
    return this.client.post<Manufaturor>(this.baseurl_manufacturor, newmanufacturor);
  }

  
}

export class Manufaturor{
  ID: number;
  Manufaturor_name: string;
}


export class Device{
  Device_ID:number;
  device_name:string;
  price:number;
  Manufaturor_ID:number;
}

export interface IfindDevice{ //an interface to find a device on it's id
  Device_ID:number,
}

export interface IDevice{
  Device_ID:number,
  device_name:string,
  price:number,
  Manufaturor_ID:number
}



