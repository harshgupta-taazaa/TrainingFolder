import { Component, OnInit } from '@angular/core';
import { AppServiceService } from '../app-service.service';

@Component({
  selector: 'app-deleteproduct',
  templateUrl: './deleteproduct.component.html',
  styleUrls: ['./deleteproduct.component.css']
})
export class DeleteproductComponent implements OnInit {

  id:string;
  constructor(private appservice:AppServiceService) { }

  ngOnInit(): void {
  }

  deleteProduct(){
    this.appservice.deleteProduct(this.id).subscribe(data=>{});
  }

}
