import { Component, OnInit, Input } from '@angular/core';
import { ApiserviceService, Device } from '../apiservice.service';



@Component({
  selector: 'app-device-add',
  templateUrl: './device-add.component.html',
  styleUrls: ['./device-add.component.css']
})

export class DeviceAddComponent implements OnInit {

  devicename: string;
  deviceID;
  manufacturorId;
  price; //simple variables to create the new device from
  apparaat:Device = new Device;

  constructor(private service: ApiserviceService) {

   }

  submit = () => {
    alert("creating new device");
    this.apparaat.device_name = this.devicename;
    this.apparaat.Device_ID = parseInt(this.deviceID);
    this.apparaat.Manufaturor_ID = parseInt(this.manufacturorId);
    this.apparaat.price = parseFloat(this.price);
    this.service_postdevice(this.apparaat); //use the function that interracts with the service
    //console.log(this.service.postdevice(this.apparaat));

  }

  service_postdevice(apparaat:Device){
    var self = this;
    self.service.postdevice(apparaat).subscribe(); //works, creates request
    
  }

  ngOnInit() {

  }

}
