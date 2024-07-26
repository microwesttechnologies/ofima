import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, tap } from 'rxjs';
import { environment } from 'Core/Config/Enviroment';
import { Category } from 'Core/Domain/Model/Menu.Model';

@Injectable({
  providedIn: 'root',
})
export class GetAllMenuService {
  constructor(private http: HttpClient) {}

  getAll(): Observable<Category[]> {
    return this.http.get<Category[]>(environment.apiUrl + 'Menu').pipe(
      tap(data => {
        data;
      })
    );
  }
}
