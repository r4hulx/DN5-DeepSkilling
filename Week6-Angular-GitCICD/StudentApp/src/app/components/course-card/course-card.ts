import { Component, EventEmitter, Input, OnChanges, Output, SimpleChanges } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Course } from '../../models/course.model';
import { CreditLabelPipe } from '../../pipes/credit-label-pipe';
import { Highlight } from '../../directives/highlight';

// Hands-On 2 (Input/Output/lifecycle), Hands-On 3 (ngClass/ngStyle/ngSwitch/directive/pipe).
@Component({
  selector: 'app-course-card',
  imports: [CommonModule, CreditLabelPipe, Highlight],
  templateUrl: './course-card.html',
  styleUrl: './course-card.css'
})
export class CourseCard implements OnChanges {
  @Input() course!: Course;
  @Input() enrolled = false;
  @Output() enrollRequested = new EventEmitter<number>();

  isExpanded = false;

  ngOnChanges(changes: SimpleChanges): void {
    if (changes['course']) {
      console.log('course changed', changes['course'].previousValue, '->', changes['course'].currentValue);
    }
  }

  get cardClasses() {
    return {
      'card--enrolled': this.enrolled,
      'card--full': this.course?.credits >= 4,
      expanded: this.isExpanded
    };
  }

  get borderStyle() {
    const colors: Record<string, string> = { passed: 'green', failed: 'red', pending: 'grey' };
    return { 'border-left-color': colors[this.course?.gradeStatus] ?? 'grey' };
  }

  toggleExpand(): void {
    this.isExpanded = !this.isExpanded;
  }

  onEnroll(): void {
    this.enrollRequested.emit(this.course.id);
  }
}
