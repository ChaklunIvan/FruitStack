import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { NavbarComponent} from "../components/navbar/navbar.component";
import { FruitListComponent} from "../components/fruit-list/fruit-list.component";
import { HomeComponent } from '../components/home/home.component';
import {AboutComponent} from "../components/about/about.component";

const routes: Routes = [
  { path: 'navbar', component: NavbarComponent},
  { path: 'fruit-list', component: FruitListComponent},
  { path: 'home', component: HomeComponent },
  { path: 'about', component: AboutComponent },
  { path: '**', redirectTo: 'home', pathMatch: 'full' }
];

@NgModule({
  declarations: [],
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
