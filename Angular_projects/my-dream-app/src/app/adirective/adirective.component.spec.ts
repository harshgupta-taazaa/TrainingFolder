import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdirectiveComponent } from './adirective.component';

describe('AdirectiveComponent', () => {
  let component: AdirectiveComponent;
  let fixture: ComponentFixture<AdirectiveComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdirectiveComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AdirectiveComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
