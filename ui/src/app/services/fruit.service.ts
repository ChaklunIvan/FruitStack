import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http';
import {Fruit} from "../interfaces/fruit";
import {map} from "rxjs";

const serverUrl = "https://localhost:7247/api/";

@Injectable({
  providedIn: 'root'
})
export class FruitService {

  constructor(private http: HttpClient) { }

  getFruitList() {
    return this.http.get<{items: Fruit[]}>(serverUrl + "fruits" + "?CurrentPage=1&PageSize=10")
      .pipe(map((data) => data.items));
  }

}
