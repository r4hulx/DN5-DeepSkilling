import { Component, OnDestroy, OnInit, inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { CourseService } from '../../services/course';

// Hands-On 2, Task 1 & 2: interpolation, property/event/two-way binding, lifecycle hooks.
@Component({
  selector: 'app-home',
  imports: [CommonModule, FormsModule],
  templateUrl: './home.html',
  styleUrl: './home.css'
})
export class Home implements OnInit, OnDestroy {
  private courseService = inject(CourseService);

  portalName = 'Student Course Portal';
  isPortalActive = true;
  message = '';
  searchTerm = '';
  coursesAvailable = 0;
  enrolledCount = 3;
  gpa = 3.8;

  onEnrollClick(): void {
    this.message = 'Enrollment opened!';
  }

  ngOnInit(): void {
    // Step 16: simulate fetching a live course count instead of a hardcoded value.
    this.courseService.getCourses().subscribe({
      next: courses => (this.coursesAvailable = courses.length),
      error: () => (this.coursesAvailable = 0)
    });
    console.log('HomeComponent initialised — courses loaded');
  }

  ngOnDestroy(): void {
    console.log('HomeComponent destroyed');
  }
}
