import { ErrorHandler, NgModule } from '@angular/core';
import { FormsModule,ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import {MatTableModule} from '@angular/material/table';


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
import { LoginformComponent } from './loginform/loginform.component';
import { ProductsearchPipe } from './productsearch.pipe';
import { PricepipePipe } from './pricepipe.pipe';
import { TemplateformComponent } from './templateform/templateform.component';
import { ObservableComponent } from './observable/observable.component';
import { Observable2Component } from './observable2/observable2.component';
import { Observable3Component } from './observable3/observable3.component';
import { Observable4Component } from './observable4/observable4.component';
import { MainobservableComponent } from './mainobservable/mainobservable.component';



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
    LoginformComponent,
    ProductsearchPipe,
    PricepipePipe,
    TemplateformComponent,
    ObservableComponent,
    Observable2Component,
    Observable3Component,
    Observable4Component,
    MainobservableComponent,
   
  ],
  imports: [
    BrowserModule,
    FormsModule,
    BrowserAnimationsModule,MatExpansionModule,RouterModule,AppRoutingModule,ReactiveFormsModule,
    MatTableModule
  ],
  providers: [{provide:ErrorHandler , useClass:GlobalerrorhandlerService}],
  bootstrap: [AppComponent]
})
export class AppModule { }
