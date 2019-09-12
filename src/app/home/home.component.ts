import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from '../shared/user.service';

// import { MenuItem } from 'primeng/api';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styles: []
})
export class HomeComponent implements OnInit {
  // userDetails;
  // menuItems: MenuItem[];

  constructor(private router: Router, private service: UserService) { }

  ngOnInit() {

    // this.menuItems = [
    //   { label: 'Status', icon: 'pi pi-fw pi-plus', routerLink: ['/home'] },
    //   { label: 'Resources', icon: 'pi pi-fw pi-download', routerLink: ['/home'] },
    // ]

    // this.service.getUserProfile().subscribe(
    //   res => {
    //     this.userDetails = res;
    //   },
    //   err => {
    //     console.log(err);
    //   }
    // );
  }



}
