import { Component, OnInit } from '@angular/core';
import { ApiserviceService } from '../apiservice.service';

@Component({
  selector: 'app-manufacturor-list',
  templateUrl: './manufacturor-list.component.html',
  styleUrls: ['./manufacturor-list.component.css']
})
export class ManufacturorListComponent implements OnInit {

  manufacturorlist;
  searchID
  constructor(private service:ApiserviceService) { }



  ngOnInit() {
    this.fetchlist();
  }

  fetchlist = () =>{
    var self = this;
    this.manufacturorlist = this.service.GetManufacturorList().subscribe(result => {this.manufacturorlist = result});
  }


  submit = () => {
    this.manufacturorlist = this.service.GetspecificManufacturor(parseInt(this.searchID)).subscribe(result =>
      {
        this.manufacturorlist = result;
      });
  }

}
