import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormControl, FormGroup, ValidatorFn, Validators } from '@angular/forms';
import { Iuser } from './User';
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
//   function ageRangeValidator(control:AbstractControl):{[key:string]:boolean}|null{
//     if (control.value!=undefined && (isNaN(control.value) || control.value<min ||control.value>max)){
//       return {'ageRange':true};
//     }
//     return null;
//   };
// }
  

@Component({
  selector: 'app-loginform',
  templateUrl: './loginform.component.html',
  styleUrls: ['./loginform.component.css']
})
export class LoginformComponent implements OnInit {
  loginForm:FormGroup;
  min=20;
  max=50;

  user:Iuser={
    email:"harsh@outlook.com",
    password:12234

  }

  constructor() { }

  ngOnInit(): void {
    this.loginForm=new FormGroup({
      email:new FormControl(null,[Validators.required]),
      password:new FormControl(null,[Validators.required,Validators.minLength(5)]),
      age:new FormControl(null,[ageRangeValidator(this.min,this.max)]),
      phonenumber:new FormControl(null,[]),
      notification:new FormControl('email',[])

    });
    this.formControlValueChanged();
  }

  login(){
    console.log(this.loginForm.value);
    console.log(this.user);
  }
  cancel(){
    this.loginForm.reset();
  }
  formControlValueChanged(){
    const phoneControl=this.loginForm?.get('phonenumber');
    this.loginForm.get('notification')?.valueChanges.subscribe((data:string)=>{
      console.log(data);
      if(data=='phone'){
        phoneControl?.setValidators([Validators.required]);
      }
      else if(data=='email'){
        phoneControl?.clearValidators();
      }
      phoneControl?.updateValueAndValidity();
    })
  }


}
