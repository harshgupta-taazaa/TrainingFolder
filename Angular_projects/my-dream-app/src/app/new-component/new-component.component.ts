import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormControl, FormGroup, ValidatorFn, Validators } from '@angular/forms';
import { IProduct } from '../product/Iproduct';
import { TempService } from '../temp.service';
function ageRangeValidator(min:number, max:number):ValidatorFn
  {
    return(control :AbstractControl):{[key:string]:boolean}|null =>
    {
      if (control.value!=undefined && (isNaN(control.value) || control.value<min ||control.value>max)){
        return {'ageRange':true};
      }
      return null;
    };
  }
@Component({
  selector: 'app-new-component',
  templateUrl: './new-component.component.html',
  styleUrls: ['./new-component.component.css']
})
export class NewComponentComponent implements OnInit {
  price:number;
  loginForm:FormGroup;
  prod:IProduct;
  min =0;
  max=10000;
  
  constructor(private data:TempService) { }

  ngOnInit(): void {
    this.data.product.subscribe(data=>{
      this.prod=data;
    })
      console.log(this.prod);
    
    this.loginForm=new FormGroup({
     Id:new FormControl(this.prod?.Id,[Validators.required]),
      Title:new FormControl(this.prod?.Title,[Validators.required,Validators.minLength(3)]),
      Price:new FormControl(this.prod?.Price,[ageRangeValidator(this.min,this.max),Validators.required]),
      ExpiryDate:new FormControl(this.prod?.ExpiryDate,[Validators.required]),
      isInStock:new FormControl(this.prod?.isInStock,[Validators.required]),
      Quantity:new FormControl(this.prod?.Quantity,[Validators.required])

    });    
  }
  setprice(){
    this.data.setprice(this.price);
  }
  updateProduct(){
    this.data.updateProduct(this.loginForm.value);
  }

}
