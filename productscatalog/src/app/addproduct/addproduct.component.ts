import { Component, OnInit } from '@angular/core';
import { DataserviceService } from '../dataservice.service';

@Component({
  selector: 'app-addproduct',
  templateUrl: './addproduct.component.html',
  styleUrls: ['./addproduct.component.css']
})
export class AddproductComponent implements OnInit {
  cname:string;
  pname:string;
  scode:string;
  price:number;
  mname:string;
  id:number;
  pid:number=5;
  data:string;
  constructor(private dataservice:DataserviceService) { 
    this.pid+=1;
  }
  
  ngOnInit(): void {
  }

  // incrementid(){
  //   this.pid=this.pid+1;
  //   return this.pid;
  // }
  submit(){
    this.dataservice.id=this.pid;
    this.dataservice.cname=this.cname;
    this.dataservice.mname=this.mname;
    this.dataservice.pname=this.pname;
    this.dataservice.scode=this.scode;
    this.dataservice.price=this.price;
    this.dataservice.addData();
    this.data="Item added successfully";


  }
}
