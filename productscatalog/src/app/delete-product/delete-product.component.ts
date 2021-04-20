import { Component, OnInit } from '@angular/core';
import { DataserviceService } from '../dataservice.service';

@Component({
  selector: 'app-delete-product',
  templateUrl: './delete-product.component.html',
  styleUrls: ['./delete-product.component.css']
})
export class DeleteProductComponent implements OnInit {

  constructor(private dataservice:DataserviceService) { }

  title:string;
  id:number;
  data:string;
  ngOnInit(): void {

  }

  submit(){
    this.dataservice.removeId=this.id;
    this.dataservice.remove()
    this.title="Deleted successfully";
    this.data="Check List Of Products"
  }

}
