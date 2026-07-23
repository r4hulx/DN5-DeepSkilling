import { TestBed } from '@angular/core/testing';
import { provideHttpClient } from '@angular/common/http';
import { provideHttpClientTesting } from '@angular/common/http/testing';
import { EnrollmentService } from './enrollment';

describe('EnrollmentService', () => {
  let service: EnrollmentService;

  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [provideHttpClient(), provideHttpClientTesting()]
    });
    service = TestBed.inject(EnrollmentService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });

  it('enroll/unenroll should toggle isEnrolled state', () => {
    expect(service.isEnrolled(1)).toBeFalsy();
    service.enroll(1);
    expect(service.isEnrolled(1)).toBeTruthy();
    service.unenroll(1);
    expect(service.isEnrolled(1)).toBeFalsy();
  });
});
