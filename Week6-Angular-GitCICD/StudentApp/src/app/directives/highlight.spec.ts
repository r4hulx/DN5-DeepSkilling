import { TestBed } from '@angular/core/testing';
import { ElementRef } from '@angular/core';
import { Highlight } from './highlight';

describe('Highlight', () => {
  it('should create an instance', () => {
    TestBed.configureTestingModule({
      providers: [Highlight, { provide: ElementRef, useValue: new ElementRef(document.createElement('div')) }]
    });
    const directive = TestBed.inject(Highlight);
    expect(directive).toBeTruthy();
  });
});
