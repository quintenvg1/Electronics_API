import { Component, OnInit, Input } from '@angular/core';
import { ApiserviceService, device } from '../apiservice.service';
import { HttpClient, HttpParams} from '@angular/common/http';


@Component({
  selector: 'app-device-add',
  templateUrl: './device-add.component.html',
  styleUrls: ['./device-add.component.css']
})

export class DeviceAddComponent implements OnInit {

  devicename: string;
  deviceID: number;
  manufacturorId: number;
  price: number; //simple variables to create the new device from
  data;
  apparaat:device = new device;

  constructor(private service: ApiserviceService, private client:HttpClient) {

   }

  submit = () => {
    alert("creating new device");
    this.apparaat.device_name = this.devicename;
    this.apparaat.Device_ID = this.deviceID;
    this.apparaat.Manufaturor_ID = this.manufacturorId;
    this.apparaat.price = this.price;
    this.postdevice(this.apparaat);
    //console.log(this.service.postdevice(this.apparaat));

  }

  async postdevice(newdevice:device){
    //console.log(this.client.get("https://localhost:44364/api/device/list"));
    console.log(this.client.post<device>("https://localhost:44364/api/device", newdevice));
    //this.client.post<device>("http://localhost:44364/api/device", newdevice); //werkt niet
    //alert('created new device and should have sended it too');
  }

  ngOnInit() {

  }

}
