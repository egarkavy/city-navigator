import { NgModule } from '@angular/core';
import { BrowserModule }  from '@angular/platform-browser';
 
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';

import { RouterModule } from '@angular/router';
import { routes } from './app.routes';
@NgModule({
  imports: [
    BrowserModule, RouterModule.forRoot(routes)
  ],
  declarations: [
    AppComponent,
    HomeComponent
  ],
  bootstrap: [ AppComponent ]
})
export class AppModule { }