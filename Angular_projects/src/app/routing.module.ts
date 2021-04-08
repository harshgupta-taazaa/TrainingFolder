import {NgModule} from '@angular/core';
import {RouterModule,Routes} from '@angular/router';
import { observable } from 'rxjs';
import { AdirectiveComponent } from './adirective/adirective.component';
import { Child2Component } from './child2/child2.component';
import { ErrorhandlerComponent } from './errorhandler/errorhandler.component';
import { HarshComponent } from './harsh/harsh.component';
import { LoginformComponent } from './loginform/loginform.component';
import { MainobservableComponent } from './mainobservable/mainobservable.component';
import { MergeComponent } from './merge/merge.component';
import { NewComponentComponent } from './new-component/new-component.component';
import { ObservableComponent } from './observable/observable.component';
import { Observable2Component } from './observable2/observable2.component';
import { Observable3Component } from './observable3/observable3.component';
import { Observable4Component } from './observable4/observable4.component';
import { ProductComponent } from './product/product.component';
import { PurchaseComponent } from './purchase/purchase.component';
import { TemplateformComponent } from './templateform/templateform.component';
import { TshirtComponent } from './tshirt/tshirt.component';



const routes :Routes=[
    {path:"",redirectTo:"home",pathMatch:"full"},
    {path:"data-binding" ,component:TshirtComponent},
    {path:"product",component:ProductComponent},
    {path:"MasterDetails",component:PurchaseComponent},
    {path :"child2", component:Child2Component},
    {path :"newcomponent",component:NewComponentComponent},
    {path:"merge",component:MergeComponent},
    {path:"adirective", component:AdirectiveComponent},
    {path:"home",component:HarshComponent},
    {path:"errorhandle" , component:ErrorhandlerComponent},
    {path:"formsmodule",component:LoginformComponent},
    {path:"templateform",component:TemplateformComponent},
    
    {path:"observable2",component:Observable2Component},
    {path:"observable3",component:Observable3Component},
    {path:"observable4",component:Observable4Component},
    {path:"mainobservalbe",component:MainobservableComponent,
    children:[
        {
        path:"observable",
        component:ObservableComponent
    },   {
        path:"observable2",
        component:Observable2Component
    },   {
        path:"observable3",
        component:Observable3Component
    },   {
        path:"observable4",
        component:Observable4Component
    }
    ]}

];
@NgModule({
    imports:[
        RouterModule.forRoot(routes)
    ],
    exports:[
        RouterModule
    ],
    declarations:[]
})
export class AppRoutingModule{}

