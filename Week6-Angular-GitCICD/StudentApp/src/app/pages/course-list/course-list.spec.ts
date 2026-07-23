import { ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { provideMockStore, MockStore } from '@ngrx/store/testing';
import { provideRouter } from '@angular/router';
import { CourseList } from './course-list';
import { selectAllCourses, selectCoursesLoading } from '../../store/course/course.selectors';
import { Course } from '../../models/course.model';

describe('CourseList', () => {
  let fixture: ComponentFixture<CourseList>;
  let store: MockStore;

  const mockCourses: Course[] = [
    { id: 1, name: 'Data Structures', code: 'CS101', credits: 4, gradeStatus: 'passed' }
  ];

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CourseList],
      providers: [
        provideRouter([]),
        provideMockStore({
          initialState: {
            course: { courses: mockCourses, loading: false, error: null },
            enrollment: { enrolledCourseIds: [] }
          }
        })
      ]
    }).compileComponents();

    store = TestBed.inject(MockStore);
    fixture = TestBed.createComponent(CourseList);
  });

  afterEach(() => {
    // MockStore.overrideSelector patches memoized selectors at the module level.
    // Without resetting, an override from one test can leak into another when
    // Jasmine's default random test order runs them in a different sequence.
    store.resetSelectors();
  });

  it('should render course cards from the store', () => {
    fixture.detectChanges();
    const cards = fixture.debugElement.queryAll(By.css('app-course-card'));
    expect(cards.length).toBe(1);
  });

  it('should show a loading indicator when loading is true', () => {
    store.overrideSelector(selectCoursesLoading, true);
    store.overrideSelector(selectAllCourses, []);
    store.refreshState();
    fixture.detectChanges();
    const loading = fixture.debugElement.query(By.css('p'));
    expect(loading.nativeElement.textContent).toContain('Loading courses');
  });
});
