import { Component, OnInit, inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormBuilder, ReactiveFormsModule, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';

import { StudentService } from '../../services/student';

@Component({
  selector: 'app-edit-student',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './edit-student.html',
  styleUrl: './edit-student.css'
})
export class EditStudentComponent implements OnInit {

  private fb = inject(FormBuilder);
  private service = inject(StudentService);
  private route = inject(ActivatedRoute);
  private router = inject(Router);

  id = 0;

  studentForm = this.fb.group({
    id: [0],
    name: ['', Validators.required],
    age: [0, Validators.required],
    department: ['', Validators.required],
    email: ['', [Validators.required, Validators.email]]
  });

  ngOnInit(): void {

    this.id = Number(this.route.snapshot.paramMap.get('id'));

    this.service.getStudent(this.id).subscribe(student => {

      this.studentForm.patchValue(student);

    });

  }

  updateStudent() {

    this.service.updateStudent(this.id, this.studentForm.value as any).subscribe({

      next: () => {

        alert("Student Updated Successfully");

        this.router.navigate(['/students']);

      },

      error: err => console.log(err)

    });

  }

}