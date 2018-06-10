import { NgModule } from '@angular/core';
import { BrowserModule }  from '@angular/platform-browser';
import { AgmCoreModule } from '@agm/core'; 
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatSelectModule } from '@angular/material';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { PlaceSummaryComponent } from './place-summary/place-summary.component';
import { PlaceDetails } from './place-details/place-details.component';

import { RouterModule } from '@angular/router';
import { routes } from './app.routes';
@NgModule({
  imports: [
    BrowserModule, 
    RouterModule.forRoot(routes), 
    AgmCoreModule.forRoot({
        apiKey: 'AIzaSyBRHD3VAgZYT2DZ29JfuZkdKBDIw8xxw8c'
      }),
    HttpClientModule,
    BrowserAnimationsModule,
    MatSelectModule
  ],
  declarations: [
    AppComponent,
    HomeComponent,
    PlaceSummaryComponent,
    PlaceDetails
  ],
  bootstrap: [ AppComponent ]
})
export class AppModule { }