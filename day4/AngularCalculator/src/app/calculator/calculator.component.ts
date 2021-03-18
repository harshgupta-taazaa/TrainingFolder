import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css']
})
export class CalculatorComponent implements OnInit {

  input1 : number=0;
  input2 : number=0;
  result : number=0;
  height : number=50;
  width : number=185;

  operator : string="op";

  calculate(name:string) {
    this.operator=name;
    switch(name)
    {
      case "+":
        this.result=this.input1+this.input2;
        break;
        case "*":
        this.result=this.input1*this.input2;
        break;
        case "-":
        this.result=this.input1-this.input2;
        break;
        case "/":
        this.result=this.input1/this.input2;
        break;
        case "%":
        this.result=this.input1%this.input2;
        break;
        case "c":
          this.result=0;
          this.operator="op";
          this.input1=0;
          this.input2=0;
    }

  }
  constructor() { }

  ngOnInit(): void {
    
  }

}
