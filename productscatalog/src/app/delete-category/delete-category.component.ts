import { Component, OnInit } from '@angular/core';
import { DataserviceService } from '../dataservice.service';

@Component({
  selector: 'app-delete-category',
  templateUrl: './delete-category.component.html',
  styleUrls: ['./delete-category.component.css']
})
export class DeleteCategoryComponent implements OnInit {

  constructor(private dataservice :DataserviceService) { }
  category:string;
  title:string;
  data:string;
  ngOnInit(): void {


  }

  submit(){
    this.dataservice.category=this.category;
    this.dataservice.removeCategory();
    this.title="Deleted items related to that category";
  }

}
