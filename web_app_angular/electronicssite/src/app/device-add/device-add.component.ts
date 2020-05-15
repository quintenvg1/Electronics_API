import { Component, OnInit, Input } from '@angular/core';

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



  constructor() { }

  submit = () => {
    alert(this.devicename);
  }

  ngOnInit() {
  }

}
