import { Component, inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormBuilder, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router } from '@angular/router';

import { StudentService } from '../../services/student';

@Component({
  selector: 'app-add-student',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './add-student.html',
  styleUrl: './add-student.css'
})
export class AddStudentComponent {

  private fb = inject(FormBuilder);
  private studentService = inject(StudentService);
  private router = inject(Router);

  studentForm = this.fb.group({
    name: ['', Validators.required],
    age: [0, Validators.required],
    department: ['', Validators.required],
    email: ['', [Validators.required, Validators.email]]
  });

  saveStudent() {

    if (this.studentForm.invalid) {
      return;
    }

    this.studentService.addStudent(this.studentForm.value as any).subscribe({
      next: () => {
        alert("Student Added Successfully");
        this.router.navigate(['/students']);
      },
      error: (err) => {
        console.log(err);
      }
    });

  }

}