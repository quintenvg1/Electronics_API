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
  constructor(private service:ApiserviceService) { }

  ngOnInit() {
    this.fetchlist();
    onload = (this.fetchlist);
  }

  fetchlist = () =>{
      var self = this;
      this.devicelist = this.service.getDeviceList().subscribe((result) => result.Device);
      console.log(this.devicelist);

  }

}
