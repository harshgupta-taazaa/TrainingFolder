import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { IProduct } from './product/Iproduct';

@Injectable({
  providedIn: 'root'
})
export class TempService {

  data:IProduct= {Id:1,
  Title:"pen",
  Price:120,
  ExpiryDate:"10-12-2021",
  isInStock:true,
  Quantity:100};

  product:BehaviorSubject<IProduct>
  constructor() { 
    this.product=new BehaviorSubject(this.data);
  }

  setprice(price:number){
    this.data.Price=price;
    this.product.next(this.data);
    
  }


  
}
