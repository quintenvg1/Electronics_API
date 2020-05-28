import { Component, OnInit, Input } from '@angular/core';
import { ApiserviceService, IDevice, Device } from '../apiservice.service';
import { DescriptionserviceService, description } from '../descriptionservice.service';

@Component({
  selector: 'app-device-list',
  templateUrl: './device-list.component.html',
  styleUrls: ['./device-list.component.css']
})
export class DeviceListComponent implements OnInit {

  manufacturorname:string; //find by manufacturor
  devicelist;
  bymanufacturor;
  devname: string;
  description: description;
  page: number = 0;
  length: number = 3;
  constructor(private service:ApiserviceService, private descriptionservice: DescriptionserviceService) { }

  ngOnInit() {
    this.fetchlist();
    //onload = (this.fetchlist);
  }

  nextpage = () =>{
    this.page += 1;
    this.fetchlist();
  }

  previouspage = () =>{
    this.page -= 1;
    if(this.page < 0){this.page = 0;}
    this.fetchlist();
  }

  fetchlist = () =>{
      var self = this;
      this.devicelist =  this.service.getDeviceList(this.page, this.length).subscribe(result => {
        console.log("lijst ontvangen");
        console.log(result);
        this.devicelist = result;
      });
  }

  describe = () =>{
      this.descriptionservice.getdescription(this.devname).subscribe(result => {
        this.description = result;
      });
  }

  delete = (id) =>{
    this.service.removespecificDevice(parseInt(id)).subscribe();
  }

  submit = () =>{
    this.devicelist = this.service.getspecificDevices(parseInt(this.bymanufacturor)).subscribe(result => {
      console.log("lijst ontvangen");
      console.log(result);
      this.devicelist = result;
    });
  }
}
