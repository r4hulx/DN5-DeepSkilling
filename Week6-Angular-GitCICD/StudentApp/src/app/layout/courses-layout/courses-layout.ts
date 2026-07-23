import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';

// Hands-On 7, Task 1, Step 72: nested route shell with its own <router-outlet>.
@Component({
  selector: 'app-courses-layout',
  imports: [RouterOutlet],
  templateUrl: './courses-layout.html',
  styleUrl: './courses-layout.css'
})
export class CoursesLayout {}
