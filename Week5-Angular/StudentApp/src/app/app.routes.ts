import { Routes } from '@angular/router';

import { HomeComponent } from './components/home/home';

import { StudentListComponent } from './components/student-list/student-list';

import { AddStudentComponent } from './components/add-student/add-student';

import { EditStudentComponent } from './components/edit-student/edit-student';

export const routes: Routes = [

{
path:'',
component:HomeComponent
},

{
path:'students',
component:StudentListComponent
},

{
path:'add',
component:AddStudentComponent
},

{
path:'edit/:id',
component:EditStudentComponent
},

{
path:'**',
redirectTo:''
}

];