import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { PlanetDetailsComponent } from './components/planet-details/planet-details.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [AppComponent, PlanetDetailsComponent],
  imports: [BrowserModule, HttpClientModule, FormsModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
