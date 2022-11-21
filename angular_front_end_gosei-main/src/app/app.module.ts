import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProfileComponent } from './profile/profile.component';
import { CalendarComponent } from './calendar/calendar.component';
import { ShiftComponent } from './shift/shift.component';
import { RouterModule } from '@angular/router';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatSliderModule } from '@angular/material/slider';
import { MatNativeDateModule } from '@angular/material/core';
import { MatButtonToggleModule } from '@angular/material/button-toggle';
import { LoginComponent } from './login/login.component';
import { MatTableModule } from '@angular/material/table';
import { HttpClientModule } from '@angular/common/http'
import { AgGridModule } from 'ag-grid-angular';
import { ClickOutsideModule } from 'ng-click-outside';
import { NavbarComponent } from './navbar/navbar.component';
import { ToastrModule, ToastNoAnimation, ToastNoAnimationModule } from 'ngx-toastr';
import { MaterialExampleModule } from './material.module';

@NgModule({
  declarations: [ 
    AppComponent,
    ProfileComponent,
    CalendarComponent,
    ShiftComponent,
    LoginComponent,
    NavbarComponent,
  ],
  imports: [
    MaterialExampleModule,
    ToastNoAnimationModule.forRoot(),
    ClickOutsideModule,
    MatButtonToggleModule,
    MatNativeDateModule,
    BrowserAnimationsModule,
    BrowserModule,
    MatSliderModule,
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    MatTableModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: ProfileComponent },
      { path: 'calendar', component: CalendarComponent },
      { path: 'shift', component: ShiftComponent },
      { path: 'login', component: LoginComponent },
    ]),
    BrowserAnimationsModule,
    HttpClientModule,
    AgGridModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
