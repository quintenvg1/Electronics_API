import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';



@Injectable({
  providedIn: 'root'
})
export class ApiserviceService {

  private baseurl: string = "https://localhost:44364/api/device";


  constructor(private client:HttpClient) { 
    }
 
  postdevice(newdevice:Device){
    return this.client.post<Device>(this.baseurl, newdevice);
  }


  
}


export class Device{
  Device_ID:number;
  device_name:string;
  price:number;
  Manufaturor_ID:number;
}

export interface IfindDevice{ //an interface to find a device on it's id
  Device_ID:number
}



