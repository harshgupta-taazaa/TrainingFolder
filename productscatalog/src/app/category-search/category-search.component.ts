import { Component, OnInit } from '@angular/core';
import { DataserviceService } from '../dataservice.service';
import { IProduct } from '../product/Iproduct';

@Component({
  selector: 'app-category-search',
  templateUrl: './category-search.component.html',
  styleUrls: ['./category-search.component.css']
})
export class CategorySearchComponent implements OnInit {
product:IProduct[]=[]
  constructor(private dataservice:DataserviceService) { }
    search:string;
  ngOnInit(): void {

    this.product=this.dataservice.getdata();
  }

}
