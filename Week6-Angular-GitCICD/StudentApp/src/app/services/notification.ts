import { Injectable } from '@angular/core';

// Hands-On 6, Task 2, Step 67: provided at COMPONENT level (see notification.ts component),
// not root. That means each component that lists this in its own `providers` array gets its
// own separate instance, scoped to that component and its children — unlike CourseService
// (providedIn: 'root') which is a single app-wide singleton.
@Injectable()
export class NotificationService {
  private messages: string[] = [];

  push(message: string): void {
    this.messages.push(message);
  }

  getAll(): string[] {
    return this.messages;
  }

  clear(): void {
    this.messages = [];
  }
}
