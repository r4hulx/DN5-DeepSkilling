import { Component, OnInit, inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import {
  AbstractControl,
  FormArray,
  FormBuilder,
  ReactiveFormsModule,
  ValidationErrors,
  Validators
} from '@angular/forms';
import { CanComponentDeactivate } from '../../guards/unsaved-changes-guard';

// Custom sync validator: disallow course codes starting with "XX".
function noCourseCode(control: AbstractControl): ValidationErrors | null {
  const value = control.value as string | number | null;
  return value && String(value).startsWith('XX') ? { noCourseCode: true } : null;
}

// Custom async validator: simulate a server check for already-taken emails.
function simulateEmailCheck(control: AbstractControl): Promise<ValidationErrors | null> {
  return new Promise(resolve => {
    setTimeout(() => {
      resolve(String(control.value).includes('test@') ? { emailTaken: true } : null);
    }, 800);
  });
}

// Hands-On 5: reactive form built with FormBuilder, custom validators, FormArray.
@Component({
  selector: 'app-reactive-enrollment-form',
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './reactive-enrollment-form.html',
  styleUrl: './reactive-enrollment-form.css'
})
export class ReactiveEnrollmentForm implements OnInit, CanComponentDeactivate {
  private fb = inject(FormBuilder);

  enrollForm = this.fb.group({
    studentName: ['', [Validators.required, Validators.minLength(3)]],
    studentEmail: ['', [Validators.required, Validators.email], [simulateEmailCheck]],
    courseId: ['', [Validators.required, noCourseCode]],
    preferredSemester: ['Odd', Validators.required],
    agreeToTerms: [false, Validators.requiredTrue],
    additionalCourses: this.fb.array<string>([])
  });

  submitted = false;

  ngOnInit(): void {}

  get additionalCourses(): FormArray {
    // Typed getter avoids repeated `as FormArray` casts scattered through the template.
    return this.enrollForm.get('additionalCourses') as FormArray;
  }

  addCourse(): void {
    this.additionalCourses.push(this.fb.control('', Validators.required));
  }

  removeCourse(index: number): void {
    this.additionalCourses.removeAt(index);
  }

  hasUnsavedChanges(): boolean {
    return this.enrollForm.dirty && !this.submitted;
  }

  onSubmit(): void {
    // .value excludes disabled controls; getRawValue() includes everything.
    console.log('value', this.enrollForm.value);
    console.log('rawValue', this.enrollForm.getRawValue());
    if (this.enrollForm.valid) {
      this.submitted = true;
      this.enrollForm.markAsPristine();
    }
  }
}
