import { Component, ErrorHandler, OnInit } from '@angular/core';
import { GlobalerrorhandlerService } from '../globalerrorhandler.service';

@Component({
  selector: 'app-errorhandler',
  templateUrl: './errorhandler.component.html',
  styleUrls: ['./errorhandler.component.css']
})
export class ErrorhandlerComponent implements OnInit {

  constructor() { }

  s:any=undefined;


  ngOnInit(): void {

  }
  handleError(){
    this.s.indexOf();
  
  }

}
