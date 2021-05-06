import { Component, OnInit } from '@angular/core';

import { Observable } from 'rxjs';
import { AppServiceService } from '../app-service.service';
import { Product } from '../Product';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
 products$:Observable<Product[]>;
  constructor(private appservice:AppServiceService) { 
    this.products$= new Observable();
  }

  ngOnInit(): void {
    this.products$=this.appservice.getProduct();
    console.log("hello");
    
  }

}
