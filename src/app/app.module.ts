import { AuthInterceptor } from './auth/auth.interceptor';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
// import { NoopAnimationsModule } from '@angular/platform-browser/animations';

import { NgModule } from '@angular/core';
import { ReactiveFormsModule, FormsModule } from "@angular/forms"
import { HttpClientModule, HTTP_INTERCEPTORS } from "@angular/common/http"
import { ToastrModule } from 'ngx-toastr';
import { AccordionModule } from 'primeng/accordion';

import { MenuModule, PanelModule } from 'primeng/primeng'
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatIconModule } from '@angular/material/icon';
import { MatCheckboxModule } from '@angular/material/';
import { MatListModule } from '@angular/material/list';
import { MatTableModule } from '@angular/material/table';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatMenuModule } from '@angular/material/menu';

import { MatButtonModule } from '@angular/material';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { MaterialModule } from './shared/material.module';
import { ResourceDialogComponent } from './cluster/resource-dialog/resource-dialog.component';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UserComponent } from './user/user.component';
import { UserService } from './shared/user.service';
import { LoginComponent } from './user/login/login.component';
import { HomeComponent } from './home/home.component';
import { NodeComponent } from './cluster/node/node.component';
import { ResourceComponent } from './cluster/resource/resource.component';
import { SpinnerComponent } from './shared/spinner.component';
import { ConfirmationDialogComponent } from './shared/confirmation-dialog/confirmation-dialog.component';
import { StatusComponent } from './cluster/status/status.component';

@NgModule({
  declarations: [
    AppComponent,
    UserComponent,
    LoginComponent,
    HomeComponent,
    NodeComponent,
    ResourceComponent,
    SpinnerComponent,
    NavMenuComponent,
    ResourceDialogComponent,
    ConfirmationDialogComponent,
    StatusComponent
  ],
  imports: [
    BrowserModule,
    MatSidenavModule,
    MatIconModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    FormsModule,
    MaterialModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot({
      progressBar: true
    }),
    MenuModule,
    PanelModule,
    AccordionModule,
    MatCheckboxModule,
    MatListModule,
    MatTableModule,
    MatToolbarModule,
    MatMenuModule,
    MatButtonModule
  ],
  providers: [UserService, {
    provide: HTTP_INTERCEPTORS,
    useClass: AuthInterceptor,
    multi: true
  }],
  bootstrap: [AppComponent],
  entryComponents: [
    ResourceDialogComponent,
    ConfirmationDialogComponent
  ]
})
export class AppModule { }
