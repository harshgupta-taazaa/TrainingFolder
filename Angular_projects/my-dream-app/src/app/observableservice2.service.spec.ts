import { TestBed } from '@angular/core/testing';

import { Observableservice2Service } from './observableservice2.service';

describe('Observableservice2Service', () => {
  let service: Observableservice2Service;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(Observableservice2Service);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
