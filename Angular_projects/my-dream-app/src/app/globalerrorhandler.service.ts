import { ErrorHandler, Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class GlobalerrorhandlerService implements ErrorHandler {

  constructor() {
    
   }
   //error:any=undefined;
  handleError(error: any): void {
    console.log("this is an error");
    // throw error;
    
  }
}
