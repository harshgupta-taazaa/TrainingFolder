import { ChangeDetectionStrategy, Component, Input, OnChanges, OnInit } from '@angular/core';
import { observable, Observable } from 'rxjs';
import { AppServiceService } from '../app-service.service';
import { Product } from '../Product';

@Component({
  selector: 'app-using-async',
  templateUrl: './using-async.component.html',
  styleUrls: ['./using-async.component.css'],
  changeDetection:ChangeDetectionStrategy.OnPush
})
export class UsingAsyncComponent implements OnChanges{

  
  @Input() products:Observable<Product[]>;
  
  constructor(){
    this.products=new Observable();
  }
  ngOnChanges(){

  }
  
}
