import { Component, OnInit } from '@angular/core';
import { FruitService } from "../../services/fruit.service";
import { Fruit } from "../../interfaces/fruit";

@Component({
  selector: 'app-fruit-list',
  templateUrl: './fruit-list.component.html',
  styleUrls: ['./fruit-list.component.css']
})
export class FruitListComponent implements OnInit{

  fruits: Fruit[] = [];

  constructor(private fruitService: FruitService) { }

  ngOnInit(): void {
    this.getFruits()
  }

  getFruits(): void{
    this.fruitService.getFruitList().subscribe(fruits => this.fruits = fruits);
  }
}
