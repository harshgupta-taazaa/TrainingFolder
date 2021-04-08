import { Component, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { Observableservice2Service } from '../observableservice2.service';

@Component({
  selector: 'app-observable2',
  templateUrl: './observable2.component.html',
  styleUrls: ['./observable2.component.css']
})
export class Observable2Component implements OnInit {

  title = 'Replay Subject';
  observer1$: Subscription;
  observer2$: Subscription;
  observer3$: Subscription;
  observer1:number[] = [];
  observer2 :number[]= [];
  observer3 :number[]= [];
  showObserver1 = false;
  showObserver2 = false;
  showObserver3 = false;

  constructor(private appservice: Observableservice2Service) {

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
