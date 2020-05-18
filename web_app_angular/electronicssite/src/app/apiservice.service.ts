import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';




@Injectable({
  providedIn: 'root'
})
export class ApiserviceService {

  private baseurl: string = "https://localhost:44364/api/device/";


  constructor(private client:HttpClient) { 
    }
 
  async postdevice(newdevice:device){
    //console.log(this.client.get("https://localhost:44364/api/device/list"));
    //console.log(this.client.post<device>("https://localhost:44364/api/device", newdevice));
    return this.client.post<device>("https://localhost:44364/api/device", newdevice); //werkt niet    
  }
  
}


export class device{
  Device_ID:number;
  device_name:string;
  price:number;
  Manufaturor_ID:number;
}

/*
export interface Iadddevice{
  DeviceID:number,
  name:string,
  Price:number,
  vendorID:number,
}
//not needed as the class is now used directly
*/

