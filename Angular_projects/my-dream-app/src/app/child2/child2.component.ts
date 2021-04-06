import { Component, OnInit } from '@angular/core';
import { IProduct } from '../product/Iproduct';
import { TempService } from '../temp.service';

@Component({
  selector: 'app-child2',
  templateUrl: './child2.component.html',
  styleUrls: ['./child2.component.css']
})
export class Child2Component implements OnInit {
data:IProduct;
  constructor(private tempservice:TempService) { 
    this.tempservice.product.subscribe(c=>{
      this.data=c;
    })


  }

  ngOnInit(): void {
  }

}
