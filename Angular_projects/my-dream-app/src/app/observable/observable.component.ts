import { Component, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { Observservice1Service } from '../observservice1.service';

@Component({
  selector: 'app-observable',
  templateUrl: './observable.component.html',
  styleUrls: ['./observable.component.css']
})
export class ObservableComponent implements OnInit {

  title = 'Subject';
  observer1$: Subscription;
  observer2$: Subscription;
  observer3$: Subscription;
  observer1:number[] = [];
  observer2 :number[]= [];
  observer3 :number[]= [];
  showObserver1 = false;
  showObserver2 = false;
  showObserver3 = false;

  constructor(private appservice: Observservice1Service) {

  }

  subscribe1() {
    this.appservice.count$.subscribe(
      (      data: number) => { this.observer1.push(data) },
      null,
      () => { this.showObserver1 = true; }
    )
  }
  susbcribe2() {
    this.appservice.count$.subscribe(
      (      data: number) => { this.observer2.push(data) },
      null,
      () => { this.showObserver2 = true; }
    )
  }
  susbcribe3() {
    this.appservice.count$.subscribe(
      (      data: number) => { this.observer3.push(data) },
      null,
      () => { this.showObserver3 = true; }
    )
  }

  ngOnInit() {

  }
  ngOnDestroy() {

  }

}
