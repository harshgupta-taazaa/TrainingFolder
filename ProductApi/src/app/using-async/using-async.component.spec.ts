import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UsingAsyncComponent } from './using-async.component';

describe('UsingAsyncComponent', () => {
  let component: UsingAsyncComponent;
  let fixture: ComponentFixture<UsingAsyncComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UsingAsyncComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UsingAsyncComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
