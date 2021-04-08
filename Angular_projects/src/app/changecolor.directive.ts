import { Directive, ElementRef, HostBinding, HostListener, Input, Renderer2 } from '@angular/core';

@Directive({
  selector: '[appChangecolor]'
})
export class ChangecolorDirective {
  @Input() color:string;
  @HostBinding('style.border') hostborder:string;

  constructor(private el :ElementRef, private renderer:Renderer2) { 
    //this.changebgcolor('red');
  }
  changebgcolor(color:string){
    this.renderer.setStyle(this.el.nativeElement,'color',color);
  }
 @HostListener('click')foo(){
   alert("hello");

 }
 @HostListener("mouseenter") abc(){
   this.changebgcolor(this.color);
   this.hostborder="5px solid green";
 }
 @HostListener("mouseleave") bgd(){
   this.changebgcolor("black");
   this.hostborder="";
 }
}
