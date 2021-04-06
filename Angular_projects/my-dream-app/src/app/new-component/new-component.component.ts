import { Component, OnInit } from '@angular/core';
import { TempService } from '../temp.service';

@Component({
  selector: 'app-new-component',
  templateUrl: './new-component.component.html',
  styleUrls: ['./new-component.component.css']
})
export class NewComponentComponent implements OnInit {
  price:number;
  constructor(private data:TempService) { }

  ngOnInit(): void {
    
    
  }
  setprice(){
    this.data.setprice(this.price);
  }

}
