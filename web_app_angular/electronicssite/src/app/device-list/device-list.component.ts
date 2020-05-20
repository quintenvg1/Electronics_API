import { Component, OnInit, Input } from '@angular/core';
import { ApiserviceService, IDevice, Device } from '../apiservice.service';

@Component({
  selector: 'app-device-list',
  templateUrl: './device-list.component.html',
  styleUrls: ['./device-list.component.css']
})
export class DeviceListComponent implements OnInit {

  manufacturorname:string; //find by manufacturor
  devicelist;
  bymanufacturor;
  constructor(private service:ApiserviceService) { }

  ngOnInit() {
    this.fetchlist();
    onload = (this.fetchlist);
  }

  fetchlist = () =>{
      var self = this;
      this.devicelist =  this.service.getDeviceList().subscribe(result => {
        console.log("lijst ontvangen");
        console.log(result);
        this.devicelist = result;
      });
  }

  submit = () =>{
    this.devicelist = this.service.getspecificDevices(parseInt(this.bymanufacturor)).subscribe(result => {
      console.log("lijst ontvangen");
      console.log(result);
      this.devicelist = result;
    });
  }
}
