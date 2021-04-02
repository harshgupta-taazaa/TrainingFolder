import { Component, OnInit } from '@angular/core';
import {IProduct} from './Iproduct';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {
 products:IProduct[]=[];
  constructor() { }

  ngOnInit(): void {
    this.products=this.getProducts();
    console.log(this.products)
  }

  getProducts():IProduct[]{
    return[
      {
        Id:1,
        Title:"pen",
        Price:234,
        isInStock:true,
        ExpiryDate:"09-12-2022",
        Quantity:48,
      },
      {
        Id:2,
        Title:"pencil",
        Price:24,
        isInStock:true,
        ExpiryDate:"10-1-2021",
        Quantity:433
      },
      {
        Id:3,
        Title:"eraser",
        Price:21,
        isInStock:true,
        ExpiryDate:"10-03-2023",
        Quantity:43
      },
      {
        Id:4,
        Title:"sharpner",
        Price:41,
        isInStock:false,
        ExpiryDate:"23-10-2024",
        Quantity:0
      },
      {
        Id:5,
        Title:"book",
        Price:2343,
        isInStock:false,
        ExpiryDate:"18-12-2020",
        Quantity:0
      },
    ]
  }

}