import { CanActivateFn, Router } from '@angular/router';
import { inject } from '@angular/core';

// Hands-On 7, Task 2: hardcoded auth flag for demo purposes.
const isLoggedIn = true;

export const authGuard: CanActivateFn = () => {
  const router = inject(Router);
  if (isLoggedIn) {
    return true;
  }
  router.navigate(['/']);
  return false;
};
