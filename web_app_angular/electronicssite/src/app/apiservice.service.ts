import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class ApiserviceService {

  private url: string = "https://localhost:44364/api/devicecontroller/";

  constructor(private client:HttpClient) {   }
 
  /*
  get Lijst(){

  }
*/
}
