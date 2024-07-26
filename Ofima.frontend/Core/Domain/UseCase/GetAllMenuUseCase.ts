import { Injectable } from '@angular/core';
import { GetAllMenuGateway } from '../Gateway/GetAllMenu.Gateway';
import { Observable } from 'rxjs';
import { Category } from '../Model/Menu.Model';


@Injectable({
  providedIn: 'root',
})
export class GetAllMenuUseCases {
  constructor(private _menuGateway: GetAllMenuGateway) {}

  getAllMenu(): Observable<Array<Category>> {
    return this._menuGateway.getAll();
  }
}
