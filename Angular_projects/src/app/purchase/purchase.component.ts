import { Component, OnInit } from '@angular/core';
import { DataService } from '../data.service';
import { IPurchaseItem } from './IPurchaseItem';

@Component({
  selector: 'app-purchase',
  templateUrl: './purchase.component.html',
  styleUrls: ['./purchase.component.css']
})
export class PurchaseComponent implements OnInit {
  purchase:IPurchaseItem[]=[];
  constructor(private DataService: DataService) { }
  ngOnInit(): void {
    this.purchase=this.DataService.getPurchase();
  }
  

}
