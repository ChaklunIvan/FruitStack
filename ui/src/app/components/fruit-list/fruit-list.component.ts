import { Component, OnInit } from '@angular/core';
import { FruitService } from "../../services/fruit.service";
import {Fruit} from "../../interfaces/fruit";
import {BehaviorSubject} from "rxjs";
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';


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

  public loading = new BehaviorSubject<boolean>(true);
  public showToast = false;
  public showPagination = false;

  constructor(private fruitService: FruitService, private modalService: NgbModal) { }

  ngOnInit(): void {
    this.getFruits()
  }

  getFruits(): void{
    this.loading.next(true);
    this.fruitService.getFruitList(this.currentPage).subscribe((result: any) => {
      this.fruits = result.items;
      this.totalCount = result.totalCount;
    },
      () => {
        this.showToast = true;
        this.loading.next(false)
      },
      () => {
        this.loading.next(false);
        this.showPagination = true
      })
  }

  pageChanged(event: number) {
    this.currentPage = event;
    this.getFruits();
  }

  getLoading(){
    return this.loading.value;
  }

  getToast(){
    return this.showToast
  }

  getPagination(){
    return this.showPagination
  }

  openVerticallyCentered(content: any) {
    this.modalService.open(content, { centered: true });
  }

}
