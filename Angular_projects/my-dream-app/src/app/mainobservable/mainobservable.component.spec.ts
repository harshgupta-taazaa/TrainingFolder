import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MainobservableComponent } from './mainobservable.component';

describe('MainobservableComponent', () => {
  let component: MainobservableComponent;
  let fixture: ComponentFixture<MainobservableComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MainobservableComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MainobservableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
