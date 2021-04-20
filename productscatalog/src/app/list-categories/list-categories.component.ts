import { Component, OnInit } from '@angular/core';
import { DataserviceService } from '../dataservice.service';
import { IProduct } from '../product/Iproduct';

@Component({
  selector: 'app-list-categories',
  templateUrl: './list-categories.component.html',
  styleUrls: ['./list-categories.component.css']
})
export class ListCategoriesComponent implements OnInit {
  product:IProduct[]=[];
  constructor(private dataservice:DataserviceService) { }

  ngOnInit(): void {
    this.product=this.dataservice.getdata();
  }


}
