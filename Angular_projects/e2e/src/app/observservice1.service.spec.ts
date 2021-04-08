import { TestBed } from '@angular/core/testing';

import { Observservice1Service } from './observservice1.service';

describe('Observservice1Service', () => {
  let service: Observservice1Service;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(Observservice1Service);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
