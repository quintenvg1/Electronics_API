import { TestBed } from '@angular/core/testing';

import { DescriptionserviceService } from './descriptionservice.service';

describe('DescriptionserviceService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: DescriptionserviceService = TestBed.get(DescriptionserviceService);
    expect(service).toBeTruthy();
  });
});
