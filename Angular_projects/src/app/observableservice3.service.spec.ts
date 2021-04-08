import { TestBed } from '@angular/core/testing';

import { Observableservice3Service } from './observableservice3.service';

describe('Observableservice3Service', () => {
  let service: Observableservice3Service;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(Observableservice3Service);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
