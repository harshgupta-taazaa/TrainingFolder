import { Component, OnInit } from '@angular/core';
import { AbstractControl, ValidatorFn } from '@angular/forms';
import { DataService } from '../data.service';
import {IProduct} from './Iproduct';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {
 products:IProduct[]=[];
 search:string;
 min=0;
 max=10000;
 price:number;
  constructor(private DataService:DataService) { }

  ngOnInit(): void {
    this.products=this.DataService.getProducts();
    console.log(this.products)
  }
  displayedColumns: string[] = ['ID', 'TITLE', 'Price',  'ExpiryDate',  'Quantity' ];
}