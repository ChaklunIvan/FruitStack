import { Component, OnInit } from '@angular/core';
import { FruitService } from "../../services/fruit.service";
import {Fruit} from "../../interfaces/fruit";


@Component({
  selector: 'app-fruit-list',
  templateUrl: './fruit-list.component.html',
  styleUrls: ['./fruit-list.component.css']
})
export class FruitListComponent implements OnInit{

  currentPage: number = 1;
  pageSize: number = 10;
  totalCount: number = 0;

  fruits: Fruit[] = [];

  constructor(private fruitService: FruitService) { }

  ngOnInit(): void {
    this.getFruits()
  }

  getFruits(): void{
    this.fruitService.getFruitList(this.currentPage).subscribe((result: any) => {
      this.fruits = result.items;
      this.totalCount = result.totalCount
    })
  }

  pageChanged(event: number) {
    this.currentPage = event;
    this.getFruits();
  }
}
