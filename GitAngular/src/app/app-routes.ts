import { Routes, RouterModule } from '@angular/router';
import { RegisterComponent } from './register/register.component';
import { ModuleWithProviders } from '@angular/core';

const appRoutes: Routes = [
  { path: 'register', component: RegisterComponent }
];

export const routing: ModuleWithProviders = RouterModule.forRoot(appRoutes);
