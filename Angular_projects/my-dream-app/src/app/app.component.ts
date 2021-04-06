import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent{
  title = "ANGULAR PROJECTS";
  showDataBinding =true;
  showproductDemo1=false;
  showpurchase=false;

  showdbdemo():void{
    this.showDataBinding=true;
    this.showproductDemo1=false;
    this.showpurchase=false;
  }

  showproductDemo():void{
    this.showproductDemo1=true;
    this.showDataBinding=false;
    this.showpurchase=false;
  }
  showPurchase():void{
    this.showpurchase=true;
    this.showDataBinding=false;
    this.showproductDemo1=false;

  }
  



}