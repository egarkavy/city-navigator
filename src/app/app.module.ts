import { NgModule } from '@angular/core';
import { HttpModule } from '@angular/http';
import { BrowserModule }  from '@angular/platform-browser';
import { AgmCoreModule } from '@agm/core'; 

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { PlaceSummaryComponent } from './place-summary/place-summary.component';

import { RouterModule } from '@angular/router';
import { routes } from './app.routes';
@NgModule({
  imports: [
    BrowserModule, 
    RouterModule.forRoot(routes), 
    AgmCoreModule.forRoot({
        apiKey: 'AIzaSyBRHD3VAgZYT2DZ29JfuZkdKBDIw8xxw8c'
      }),
    HttpModule
  ],
  declarations: [
    AppComponent,
    HomeComponent,
    PlaceSummaryComponent
  ],
  bootstrap: [ AppComponent ]
})
export class AppModule { }