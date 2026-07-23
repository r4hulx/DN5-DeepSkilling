import { ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { CourseCard } from './course-card';
import { Course } from '../../models/course.model';

describe('CourseCard', () => {
  let component: CourseCard;
  let fixture: ComponentFixture<CourseCard>;

  const mockCourse: Course = { id: 1, name: 'Data Structures', code: 'CS101', credits: 4, gradeStatus: 'passed' };

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CourseCard]
    }).compileComponents();

    fixture = TestBed.createComponent(CourseCard);
    component = fixture.componentInstance;
    component.course = mockCourse;
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should render the course name', () => {
    fixture.detectChanges();
    const h3 = fixture.debugElement.query(By.css('h3')).nativeElement as HTMLElement;
    expect(h3.textContent).toContain('Data Structures');
  });

  it('should emit enrollRequested with the course id when Enroll is clicked', () => {
    fixture.detectChanges();
    spyOn(component.enrollRequested, 'emit');
    const enrollButton = fixture.debugElement.queryAll(By.css('button'))[0].nativeElement as HTMLButtonElement;
    enrollButton.click();
    fixture.detectChanges();
    expect(component.enrollRequested.emit).toHaveBeenCalledWith(1);
  });

  it('should toggle isExpanded when Show Details is clicked', () => {
    fixture.detectChanges();
    expect(component.isExpanded).toBeFalse();
    const detailsButton = fixture.debugElement.queryAll(By.css('button'))[1].nativeElement as HTMLButtonElement;
    detailsButton.click();
    expect(component.isExpanded).toBeTrue();
  });

  it('ngOnChanges should log the previous and current course value', () => {
    spyOn(console, 'log');
    component.ngOnChanges({
      course: {
        previousValue: undefined,
        currentValue: mockCourse,
        firstChange: true,
        isFirstChange: () => true
      }
    });
    expect(console.log).toHaveBeenCalled();
  });
});
