import { Component, OnInit, inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

import { StudentService } from '../../services/student';
import { Student } from '../../models/student';

@Component({
  selector: 'app-student-list',
  standalone: true,
  imports: [CommonModule, RouterModule],
  templateUrl: './student-list.html',
  styleUrls: ['./student-list.css']
})
export class StudentListComponent implements OnInit {

  students: Student[] = [];

  private studentService = inject(StudentService);

  ngOnInit(): void {

  alert();

  this.loadStudents();

}

  loadStudents(): void {

    this.studentService.getStudents().subscribe({

      next: (data: Student[]) => {

        console.log("API Response:", data);

        this.students = [...data];

        console.log("Students Array:", this.students);
        console.log("Length:", this.students.length);

      },

      error: (error) => {

        console.error(error);

      }

    });

  }

  deleteStudent(id: number): void {

    if (confirm("Are you sure you want to delete this student?")) {

      this.studentService.deleteStudent(id).subscribe({

        next: () => {

          alert("Student Deleted Successfully");

          this.loadStudents();

        },

        error: (error) => {

          console.error(error);

        }

      });

    }

  }

}