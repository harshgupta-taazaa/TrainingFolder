import { Component, Input, OnInit } from '@angular/core';
import { IPurchaseItem } from '../purchase/IPurchaseItem';

@Component({
  selector: 'app-purchaseorder',
  templateUrl: './purchaseorder.component.html',
  styleUrls: ['./purchaseorder.component.css']
})
export class PurchaseorderComponent implements OnInit {
@Input() PurchaseItem : IPurchaseItem;
price=0;
  constructor() { }

  ngOnInit(): void {
  }
  ngOnChanges():void{
    console.log(this.PurchaseItem);
    this.PurchaseItem.Items.forEach(i=>{
      this.price=this.price+i.Price;
    })
  
  }
}
