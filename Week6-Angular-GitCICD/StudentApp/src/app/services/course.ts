import { Injectable, inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, catchError, map, retry, tap, throwError } from 'rxjs';
import { Course } from '../models/course.model';

// Hands-On 6: service as the single source of course data (singleton via providedIn:'root').
// Hands-On 8: refactored from hardcoded data to real HttpClient calls against JSON Server.
@Injectable({ providedIn: 'root' })
export class CourseService {
  private http = inject(HttpClient);
  private apiUrl = 'http://localhost:3000/courses';

  getCourses(): Observable<Course[]> {
    return this.http.get<Course[]>(this.apiUrl).pipe(
      map(courses => courses.filter(c => c.credits > 0)), // map: drop malformed 0-credit records
      tap(courses => console.log('Courses loaded:', courses.length)), // tap: side-effect logging only
      retry(2), // retry failed requests up to 2 times before failing
      catchError(err => {
        console.error('CourseService.getCourses failed', err);
        return throwError(() => new Error('Failed to load courses. Please try again.'));
      })
    );
  }

  getCourseById(id: number): Observable<Course> {
    return this.http.get<Course>(`${this.apiUrl}/${id}`).pipe(
      catchError(err => {
        console.error('CourseService.getCourseById failed', err);
        return throwError(() => new Error('Failed to load the requested course.'));
      })
    );
  }

  createCourse(course: Omit<Course, 'id'>): Observable<Course> {
    return this.http.post<Course>(this.apiUrl, course);
  }

  updateCourse(course: Course): Observable<Course> {
    return this.http.put<Course>(`${this.apiUrl}/${course.id}`, course);
  }

  deleteCourse(id: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }
}
