import { TestBed } from '@angular/core/testing';
import { CanDeactivateFn } from '@angular/router';
import { unsavedChangesGuard, CanComponentDeactivate } from './unsaved-changes-guard';

describe('unsavedChangesGuard', () => {
  const executeGuard: CanDeactivateFn<CanComponentDeactivate> = (...params) =>
    TestBed.runInInjectionContext(() => unsavedChangesGuard(...params));

  beforeEach(() => {
    TestBed.configureTestingModule({});
  });

  it('allows navigation when there are no unsaved changes', () => {
    const component: CanComponentDeactivate = { hasUnsavedChanges: () => false };
    const result = executeGuard(component, null as any, null as any, null as any);
    expect(result).toBeTruthy();
  });

  it('asks for confirmation when there are unsaved changes', () => {
    spyOn(window, 'confirm').and.returnValue(true);
    const component: CanComponentDeactivate = { hasUnsavedChanges: () => true };
    const result = executeGuard(component, null as any, null as any, null as any);
    expect(window.confirm).toHaveBeenCalled();
    expect(result).toBeTruthy();
  });
});
