import { ChangeDetectionStrategy, ChangeDetectorRef, Component, Input, OnChanges, OnInit } from '@angular/core';
import { Observable, Subscription } from 'rxjs';

import { Product } from '../Product';

@Component({
  selector: 'app-using-subscribe',
  templateUrl: './using-subscribe.component.html',
  styleUrls: ['./using-subscribe.component.css'],
 changeDetection:ChangeDetectionStrategy.OnPush
})
export class UsingSubscribeComponent implements OnChanges {
@Input() products:Observable<Product[]>;

data:Product[]=[];

productsubscription :Subscription;
  constructor(private cd: ChangeDetectorRef) { 
    this.productsubscription=new Subscription();
    this.products=new Observable<Product[]>();
  }
 
  ngOnChanges(): void {
    this.productsubscription=this.products.subscribe(
      data=>{
        this.data=data;
        this.cd.markForCheck();
        console.log(this.data);
      },
      errors=>{
        console.log(errors)
      },
      ()=>console.log('complete')
      
    )
  }

}
