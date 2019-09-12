import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { UserService } from 'src/app/shared/user.service';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styles: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  formModel = {
    HostIP: '192.168.29.128',
    UserName: 'root',
    Password: 'ny8yjyfe22'
  }
  constructor(private service: UserService, private router: Router, private toastr: ToastrService) { }

  ngOnInit() {
    if (localStorage.getItem('token') != null)
      this.router.navigateByUrl('/status');
  }

  onSubmit(form: NgForm) {
    this.service.login(form.value).subscribe(
      (res: any) => {
        localStorage.setItem('token', res.token);
        this.router.navigateByUrl('/status');
      },
      err => {
        if (err.status == 400)
          this.toastr.error('Nieprawidłowa nazwa użytkownika lub hasło',
            'BŁąd logowania');
        else
          console.log(err);
      }
    );
  }
}
