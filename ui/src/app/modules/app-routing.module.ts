import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { NavbarComponent} from "../components/navbar/navbar.component";
import { FruitListComponent} from "../components/fruit-list/fruit-list.component";

const routes: Routes = [
  { path: 'navbar', component: NavbarComponent},
  { path: 'fruit-list', component: FruitListComponent},
];

@NgModule({
  declarations: [],
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
