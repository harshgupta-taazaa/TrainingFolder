import { ErrorHandler, NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { TshirtComponent } from './tshirt/tshirt.component';
import { HelloComponent } from './hello/hello.component';
import { ProductComponent } from './product/product.component';
import { PurchaseComponent } from './purchase/purchase.component';
import { ServeComponent } from './serve/serve.component';
import { PurchaseorderComponent } from './purchaseorder/purchaseorder.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatExpansionModule} from '@angular/material/expansion';
import { GlobalerrorhandlerService } from './globalerrorhandler.service';
import { AppRoutingModule } from './routing.module';
import {RouterModule} from '@angular/router';
import { NewComponentComponent } from './new-component/new-component.component';
import { Child2Component } from './child2/child2.component';
import { MergeComponent } from './merge/merge.component';
import { ChangecolorDirective } from './changecolor.directive';
import { AdirectiveComponent } from './adirective/adirective.component';
import { HarshComponent } from './harsh/harsh.component';
import { ErrorhandlerComponent } from './errorhandler/errorhandler.component';


@NgModule({
  declarations: [
    AppComponent,
    TshirtComponent,
    HelloComponent,
    ProductComponent,
    PurchaseComponent,
    ServeComponent,
    PurchaseorderComponent,
    NewComponentComponent,
    Child2Component,
    MergeComponent,
    ChangecolorDirective,
    AdirectiveComponent,
    HarshComponent,
    ErrorhandlerComponent,
   
  ],
  imports: [
    BrowserModule,
    FormsModule,
    BrowserAnimationsModule,MatExpansionModule,RouterModule,AppRoutingModule
  ],
  providers: [{provide:ErrorHandler , useClass:GlobalerrorhandlerService}],
  bootstrap: [AppComponent]
})
export class AppModule { }
