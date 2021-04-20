import { Component, OnInit } from '@angular/core';
import { DataserviceService } from '../dataservice.service';
import { IProduct } from '../product/Iproduct';

@Component({
  selector: 'app-search-product',
  templateUrl: './search-product.component.html',
  styleUrls: ['./search-product.component.css']
})
export class SearchProductComponent implements OnInit {

  constructor(private dataservice :DataserviceService) { }
  search:string ;
  price:number;
  product:IProduct[]=[]

  ngOnInit(): void {
    this.product=this.dataservice.getdata();
  }

}
