import { CanDeactivateFn } from '@angular/router';

export interface CanComponentDeactivate {
  hasUnsavedChanges: () => boolean;
}

// Hands-On 7, Task 2, Step 77: warns the user before leaving a dirty form.
export const unsavedChangesGuard: CanDeactivateFn<CanComponentDeactivate> = component => {
  if (component.hasUnsavedChanges && component.hasUnsavedChanges()) {
    return window.confirm('You have unsaved changes. Leave?');
  }
  return true;
};
