import { Injectable, inject } from '@angular/core';
import { Observable, map, switchMap } from 'rxjs';
import { CourseService } from './course';
import { Course } from '../models/course.model';

// Hands-On 6, Task 2: service-to-service injection + shared enrollment state.
@Injectable({ providedIn: 'root' })
export class EnrollmentService {
  private courseService = inject(CourseService);
  private enrolledCourseIds: number[] = [];

  enroll(courseId: number): void {
    if (!this.isEnrolled(courseId)) {
      this.enrolledCourseIds.push(courseId);
    }
  }

  unenroll(courseId: number): void {
    this.enrolledCourseIds = this.enrolledCourseIds.filter(id => id !== courseId);
  }

  isEnrolled(courseId: number): boolean {
    return this.enrolledCourseIds.includes(courseId);
  }

  getEnrolledCourses(): Observable<Course[]> {
    return this.courseService.getCourses().pipe(
      map(courses => courses.filter(c => this.enrolledCourseIds.includes(c.id)))
    );
  }

  // Hands-On 8, Task 2: switchMap chains a dependent HTTP call and cancels the
  // previous in-flight request if a new courseId arrives before it completes.
  getStudentsByCourse(courseId$: Observable<number>): Observable<any[]> {
    return courseId$.pipe(
      switchMap(courseId =>
        this.courseService.getCourseById(courseId).pipe(map(() => [] as any[]))
      )
    );
  }
}
