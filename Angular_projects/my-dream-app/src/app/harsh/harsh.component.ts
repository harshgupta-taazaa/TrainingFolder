import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-harsh',
  templateUrl: './harsh.component.html',
  styleUrls: ['./harsh.component.css']
})
export class HarshComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  imagesource='../assets/angular.jpg';
  
  changeimage(){
    this.imagesource='../assets/dhananjay.jpg';
  }
  realimage(){
    this.imagesource='../assets/angular.jpg';

  }
}
