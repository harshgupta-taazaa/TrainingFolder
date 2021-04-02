import { Component, OnInit } from '@angular/core';
import { IPurchaseItem } from './IPurchaseItem';

@Component({
  selector: 'app-purchase',
  templateUrl: './purchase.component.html',
  styleUrls: ['./purchase.component.css']
})
export class PurchaseComponent implements OnInit {
  purchase:IPurchaseItem[]=[];
  constructor() { }
  ngOnInit(): void {
    this.purchase=this.getPurchase();
  }
  getPurchase():IPurchaseItem[]{
    return[{
      Id:1,
    Name:"rahul",
    Date:"20-1-2020",
    Vendorname:"GHANSHAYAM",
    Items:[{
      Id:1,
        Title:"pen",
        Price:234,
        isInStock:true,
        ExpiryDate:"09-12-2022",
        Quantity:48,
    }]
  },
  {
    Id:2,
  Name:"nikhil",
  Date:"30-12-2020",
  Vendorname:"RAM",
  Items:[{
    Id:2,
      Title:"eraser",
      Price:34,
      isInStock:true,
      ExpiryDate:"09-12-2022",
      Quantity:48,
  },{
    Id:2,
      Title:"chips",
      Price:34,
      isInStock:true,
      ExpiryDate:"09-12-2022",
      Quantity:48,
  }]
},
{
  Id:2,
Name:"karan",
Date:"12-12-2020",
Vendorname:"shayam",
Items:[{
  Id:2,
    Title:"pen",
    Price:234,
    isInStock:true,
    ExpiryDate:"09-12-2022",
    Quantity:48,
}]
},
  ]
  }

}
