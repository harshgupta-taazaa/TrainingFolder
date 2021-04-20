import { Component, OnInit } from '@angular/core';
import { DataserviceService } from '../dataservice.service';
import { IProduct } from '../product/Iproduct';

@Component({
  selector: 'app-show-product',
  templateUrl: './show-product.component.html',
  styleUrls: ['./show-product.component.css']
})
export class ShowProductComponent implements OnInit {

  constructor(private dataservice :DataserviceService) { }
  product:IProduct[]=[

   ]

  ngOnInit(): void {
    this.product=this.dataservice.getdata();
  }

}
