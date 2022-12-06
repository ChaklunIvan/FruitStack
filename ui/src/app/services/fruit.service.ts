import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Fruit } from "../interfaces/fruit";


@Injectable({
  providedIn: 'root'
})
export class FruitService {


  constructor(private http: HttpClient) { }

  getFruitList(){
    return this.http.get<Fruit[]>("https://localhost:7247/api/fruits");
  }
}
