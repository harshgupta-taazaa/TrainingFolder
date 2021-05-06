import { Component, OnInit } from '@angular/core';
import{FormBuilder,FormGroup,FormControl, Validators} from '@angular/forms'
import { AppServiceService } from '../app-service.service';
import { Product } from '../Product';

@Component({
  selector: 'app-update-product',
  templateUrl: './update-product.component.html',
  styleUrls: ['./update-product.component.css']
})
export class UpdateProductComponent implements OnInit {
  item:Product;
  ProductForm:FormGroup;
  constructor(private appservice:AppServiceService,private fb:FormBuilder){
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
  updateData(){
    const a= this.ProductForm.controls['id'].value;

    console.log(a);
    this.appservice.UpdateProduct(a,this.ProductForm.value).subscribe(data=>{});

  }
  

}
