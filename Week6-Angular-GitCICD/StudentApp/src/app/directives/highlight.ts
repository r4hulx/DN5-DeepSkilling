import { Directive, ElementRef, HostListener, Input, inject } from '@angular/core';

// Hands-On 3, Task 3: configurable highlight-on-hover attribute directive.
// Usage: <app-course-card appHighlight="lightblue">
@Directive({
  selector: '[appHighlight]'
})
export class Highlight {
  private el = inject(ElementRef);

  @Input() appHighlight = 'yellow';

  @HostListener('mouseenter')
  onMouseEnter(): void {
    this.el.nativeElement.style.backgroundColor = this.appHighlight;
  }

  @HostListener('mouseleave')
  onMouseLeave(): void {
    this.el.nativeElement.style.backgroundColor = '';
  }
}
