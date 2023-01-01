import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http';
import {Fruit} from "../interfaces/fruit";
import {map} from "rxjs";

const serverUrl = "https://localhost:7247/api/";
const pageSize = 10;

@Injectable({
  providedIn: 'root'
})
export class FruitService {

  constructor(private http: HttpClient) { }

  getFruitList(pageNumber: number) {
    return this.http.get(serverUrl + "fruits" + "?CurrentPage=" + pageNumber + "&PageSize=" + pageSize);
  }


}
