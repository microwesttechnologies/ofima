import { Observable } from "rxjs";
import { Category } from "../Model/Menu.Model";

export abstract class GetAllMenuGateway {
    abstract getAll(): Observable<Array<Category>>;
}