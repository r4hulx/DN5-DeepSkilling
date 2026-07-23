import { Component, inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoadingService } from '../../services/loading';
import { NotificationService } from '../../services/notification';

// Hands-On 6, Step 67: NotificationService is provided HERE at the component level,
// so this component (and any children) gets its own isolated instance — separate
// from any other component that might also list NotificationService in its providers.
@Component({
  selector: 'app-notification',
  imports: [CommonModule],
  providers: [NotificationService],
  templateUrl: './notification.html',
  styleUrl: './notification.css'
})
export class Notification {
  private loadingService = inject(LoadingService);
  notificationService = inject(NotificationService);

  isLoading$ = this.loadingService.isLoading$;
}
