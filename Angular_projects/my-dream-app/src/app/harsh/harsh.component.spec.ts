import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HarshComponent } from './harsh.component';

describe('HarshComponent', () => {
  let component: HarshComponent;
  let fixture: ComponentFixture<HarshComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HarshComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HarshComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
