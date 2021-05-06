import { Component, OnInit } from '@angular/core';
import{FormBuilder,FormGroup,FormControl, Validators} from '@angular/forms'
import { AppServiceService } from '../app-service.service';
import { Product } from '../Product';


@Component({
  selector: 'app-addproduct',
  templateUrl: './addproduct.component.html',
  styleUrls: ['./addproduct.component.css']
})
export class AddproductComponent implements OnInit {
  item:Product;
  ProductForm:FormGroup;
  constructor(private fb:FormBuilder, private appservice:AppServiceService) { 
    this.ProductForm=fb.group({
      id:new FormControl([Validators.required]),
      title: new FormControl("",[Validators.required]),
      price: new FormControl([Validators.required]),
      quantity: new FormControl([Validators.required]),
      color: new FormControl("",[Validators.required]),
      expiryDate: new FormControl("",[Validators.required]),
      inStock: new FormControl(true,[Validators.required]),

    })
  }
  
  ngOnInit(): void {
  }
  
  AddData(){
    let task ={
      id:5,title:"mango",price:100,quantity:14,color:"yellow",expiryDate:"12-4-2021",inStock:true
  }
    console.log(this.ProductForm.value);
    this.item=this.ProductForm.value;

    this.appservice.addProduct(this.ProductForm.value).subscribe(data=>{});
    
  }

}
