import { Component, OnInit } from '@angular/core';
import { ApiserviceService, IfindDevice } from '../apiservice.service';

@Component({
  selector: 'app-device-remove',
  templateUrl: './device-remove.component.html',
  styleUrls: ['./device-remove.component.css']
})
export class DeviceRemoveComponent implements OnInit {

  manufacturorname:string; //find by manufacturor
  devicelist;
  byId;
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
    var self = this;
    self.service.removespecificDevice(parseInt(this.byId)).subscribe();
  }
}
