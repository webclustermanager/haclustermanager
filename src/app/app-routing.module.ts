import { AuthGuard } from './auth/auth.guard';
import { UserComponent } from './user/user.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './user/login/login.component';
import { ResourceComponent } from './cluster/resource/resource.component';
import { StatusComponent } from './cluster/status/status.component';

const routes: Routes = [
  { path: '', redirectTo: '/user/login', pathMatch: 'full' },
  {
    path: 'user', component: UserComponent,
    children: [
      { path: 'login', component: LoginComponent }
    ],
  },
  { path: 'status', component: StatusComponent, canActivate: [AuthGuard] },
  { path: 'resource', component: ResourceComponent, canActivate: [AuthGuard] }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
