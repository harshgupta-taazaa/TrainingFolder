import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-tshirt',
  templateUrl: './tshirt.component.html',
  styleUrls: ['./tshirt.component.css']
})
export class TshirtComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  a = 300;
  b = 300;
  imgSource = '../assets/front.jpg';
   
  changeTshirtMouseEnter()
  {
    this.imgSource = '../assets/back.jpg';
  }
  changeTshirtMouseExit():void
   
  {
    this.imgSource = '../assets/front.jpg';
  }
  
}


