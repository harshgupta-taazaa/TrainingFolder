import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

import { Observable, throwError } from 'rxjs';
import{catchError,tap} from 'rxjs/operators'
import { environment } from 'src/environments/environment';
import { Product } from './Product';

@Injectable({
  providedIn: 'root'
})
export class AppServiceService {

  constructor(private http :HttpClient) { }

  getProduct():Observable<Product[]>{
    const apiurl = environment.apibaseurl+"Products";
    const headers ={'content-type':'application/json'};

    return this.http.get<Product[]>(apiurl,{'headers':headers}).pipe(
      tap(data=>{console.log(data)}),
      catchError(error=>{
        return throwError(error);
       } )  
    );
  }
  addProduct(item:Product):Observable<Product[]>{
    const apiurl = "https://localhost:44376/api/Products";
    const headers ={'content-type':'application/json'};
    Object.defineProperty(item,'id',{'enumerable':false});
    const itemtodoadd =JSON.stringify(item);
    console.log(itemtodoadd)
    return this.http.post<Product[]>(apiurl,itemtodoadd,{'headers':headers}).pipe(
      tap((data)=>{console.log(data)}),
      catchError((error)=>{
        return throwError(error)
      })
    );
  }
  deleteProduct(id:string):Observable<Product[]>{
    const apiurl = "https://localhost:44376/api/Products/"+id;
    const headers ={'content-type':'application/json'};
    const IdtoDelete={"id":parseInt(id)}
    return this.http.delete<Product[]>(apiurl,{'headers':headers}).pipe(
      tap((data)=>{console.log(data)}),
      catchError((error)=>{
        return throwError(error)
      })
    );
  }
  UpdateProduct(id:number,item:Product):Observable<Product[]>{
    const apiurl = "https://localhost:44376/api/Products/"+String(id);
    const headers ={'content-type':'application/json'};
    // Object.defineProperty(item,'id',{'enumerable':false});
    // const itemtodoadd =JSON.stringify(item);
    //console.log(itemtodoadd)
    return this.http.put<Product[]>(apiurl,item,{'headers':headers}).pipe(
      tap((data)=>{console.log(data)}),
      catchError((error)=>{
        return throwError(error)
      })
    );
  }

}
