import { Component, OnInit, inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';
import { Store } from '@ngrx/store';
import { Observable } from 'rxjs';
import { CourseCard } from '../../components/course-card/course-card';
import { Course } from '../../models/course.model';
import { loadCourses } from '../../store/course/course.actions';
import { selectAllCourses, selectCoursesError, selectCoursesLoading } from '../../store/course/course.selectors';
import { enrollInCourse, unenrollFromCourse } from '../../store/enrollment/enrollment.actions';
import { selectEnrolledIds } from '../../store/enrollment/enrollment.selectors';

// Hands-On 3 (structural directives), Hands-On 7 (navigation/query params),
// Hands-On 9 (data now sourced from the NgRx store instead of the service directly).
@Component({
  selector: 'app-course-list',
  imports: [CommonModule, FormsModule, CourseCard],
  templateUrl: './course-list.html',
  styleUrl: './course-list.css'
})
export class CourseList implements OnInit {
  private store = inject(Store);
  private router = inject(Router);
  private route = inject(ActivatedRoute);

  courses$: Observable<Course[]> = this.store.select(selectAllCourses);
  loading$: Observable<boolean> = this.store.select(selectCoursesLoading);
  error$: Observable<string | null> = this.store.select(selectCoursesError);
  enrolledIds$: Observable<number[]> = this.store.select(selectEnrolledIds);

  searchTerm = '';

  trackByCourseId(index: number, course: Course): number {
    return course.id; // avoids re-rendering every card on unrelated array changes
  }

  ngOnInit(): void {
    this.store.dispatch(loadCourses());
    this.searchTerm = this.route.snapshot.queryParamMap.get('search') ?? '';
  }

  onSearch(): void {
    this.router.navigate(['/courses'], { queryParams: { search: this.searchTerm || null } });
  }

  goToDetail(courseId: number): void {
    this.router.navigate(['/courses', courseId]);
  }

  onEnrollToggle(courseId: number, enrolledIds: number[]): void {
    if (enrolledIds.includes(courseId)) {
      this.store.dispatch(unenrollFromCourse({ courseId }));
    } else {
      this.store.dispatch(enrollInCourse({ courseId }));
    }
  }
}
