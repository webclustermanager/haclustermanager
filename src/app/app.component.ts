import { Component, ViewChild } from '@angular/core';
// import { MenuModule } from 'primeng/menu';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Angular';

  // @ViewChild('bigMenu') bigMenu: Menu;
  // @ViewChild('smallMenu') smallMenu: Menu;

  constructor() { }

  ngOnInit() {
  }
}