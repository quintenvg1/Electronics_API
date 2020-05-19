import { Component, OnInit } from '@angular/core';
import { ApiserviceService } from '../apiservice.service';

@Component({
  selector: 'app-device-list',
  templateUrl: './device-list.component.html',
  styleUrls: ['./device-list.component.css']
})
export class DeviceListComponent implements OnInit {

  manufacturorname:string; //find by manufacturor

  constructor(private service:ApiserviceService) { }

  ngOnInit() {
  }

  fetchlist(){

  }

}
