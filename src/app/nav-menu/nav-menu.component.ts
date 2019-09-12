import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
    selector: 'app-nav-menu',
    templateUrl: './nav-menu.component.html',
    styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
    isExpanded = false;
    userName: string;
    constructor(private router: Router) {
        this.userName = "hacluster";
    }

    collapse() {
        this.isExpanded = false;
    }

    toggle() {
        this.isExpanded = !this.isExpanded;
    }

    onLogout() {
        localStorage.removeItem('token');
        this.router.navigate(['/user/login']);
    }

    btnResourceClick = function () {
        this.router.navigate(['/resource']);
    };

    btnStatusClick = function () {
        this.router.navigate(['/status']);
    };
}



