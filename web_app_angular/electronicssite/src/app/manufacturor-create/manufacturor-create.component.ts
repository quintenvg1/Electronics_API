import { Component, OnInit } from '@angular/core';
import { ApiserviceService, Manufaturor } from '../apiservice.service';

@Component({
  selector: 'app-manufacturor-create',
  templateUrl: './manufacturor-create.component.html',
  styleUrls: ['./manufacturor-create.component.css']
})
export class ManufacturorCreateComponent implements OnInit {

  constructor(private service:ApiserviceService) { }

  newman:Manufaturor = new Manufaturor();
  name: string;


  ngOnInit() {

  }

  post_manufacturor = (newman:Manufaturor) =>{
    var self = this;
    this.service.AddnewManufacturor(this.newman).subscribe();
  }

  submit = () => {
    this.newman.ID = 0;
    this.newman.Manufaturor_name = this.name;
    this.post_manufacturor(this.newman);
  }
}