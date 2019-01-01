import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { RegisterComponent } from './register/register.component';
import { routing } from './app-routes';
import { FormsModule } from '@angular/forms';
import { DataService } from './shared/data_service/data.service';
import { HttpModule } from '@angular/http';
import { ConfigService } from './shared/config.service';

@NgModule({
  declarations: [
    AppComponent,
    RegisterComponent
  ],
  imports: [
    BrowserModule,
    routing,
    FormsModule,
    HttpModule
  ],
  providers: [DataService, ConfigService],
  bootstrap: [AppComponent]
})
export class AppModule { }
