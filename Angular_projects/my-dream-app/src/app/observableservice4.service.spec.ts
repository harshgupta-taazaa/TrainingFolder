import { TestBed } from '@angular/core/testing';

import { Observableservice4Service } from './observableservice4.service';

describe('Observableservice4Service', () => {
  let service: Observableservice4Service;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(Observableservice4Service);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
