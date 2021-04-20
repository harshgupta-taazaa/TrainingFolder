import { Injectable } from '@angular/core';
import { IProduct } from './product/Iproduct';

@Injectable({
  providedIn: 'root'
})
export class DataserviceService {
  

  constructor() {
    
  }
  cname:string;
  pname:string;
  scode:string;
  price:number;
  mname:string;
  id:number;
  removeId:number;
  category:string;
  products:IProduct[]=[
    {
      ProductId:1,
   ProductName:"pen",
    Price:10,
    CategoryName:"stationary",
    Manufacturer:"cello",
    ShortCode:"pn"
    },
    {
      ProductId:2,
   ProductName:"pencil",
    Price:5,
    CategoryName:"stationary",
    Manufacturer:"natraj",
    ShortCode:"pncl"
    },
    {
      ProductId:3,
   ProductName:"apple",
    Price:109,
    CategoryName:"fruit",
    Manufacturer:"tree",
    ShortCode:"apl"
    },
    {
      ProductId:4,
   ProductName:"potato",
    Price:20,
    CategoryName:"vegetable",
    Manufacturer:"god",
    ShortCode:"pt"
    },
    {
      ProductId:5,
   ProductName:"samsung A50",
    Price:20000,
    CategoryName:"smart phone",
    Manufacturer:"samsung",
    ShortCode:"sm"
    }



   ]

  
   getdata():IProduct[]{
     return this.products;
   }
   
   addData():IProduct[]{
    this.products.push(  {
      ProductId:this.id,
   ProductName:this.pname,
    Price:this.price,
    CategoryName:this.cname,
    Manufacturer:this.mname,
    ShortCode:this.scode
    });

    return this.products;
}
remove() {
  this.products = this.products.filter(item => item.ProductId !==this.removeId  );

  return this.products;
}
removeCategory() {
  this.products = this.products.filter(item => item.CategoryName !==this.category );

  return this.products;
}

}