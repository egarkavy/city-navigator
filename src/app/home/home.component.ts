import { Component } from "@angular/core";
import Place from "../models/place";
import { HttpClient } from '@angular/common/http';
import { Category, SubCategory } from '../models/category'
import { Observable } from "rxjs";
import { map } from 'rxjs/operators';

@Component({
    selector: 'home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.scss']
})
export class HomeComponent{ 
    latitude: number = 53.9121867;
    longitude: number = 27.5811648;

    places: Place[] = [];
    categories: Category[] = [];

    filteredCategories: Place[] = [];

    constructor(private http: HttpClient) {
        debugger;
        const placesObserver = this.http.get<Place[]>("http://localhost:60000/api/places");
        const categoriesObserver = this.http.get<Category[]>('http://localhost:60000/api/category');

        categoriesObserver.subscribe(categories => {
                
                placesObserver.subscribe(places => {
                    debugger;
                    this.places = places;

                    this.categories = categories;

                    this.filterCategories(this.categories[0].subcategories[0].id);
                });
                
            });
    }

    filterCategories(subcategoryId: string) {
        this.filteredCategories = this.places.filter(x => x.categoryId === subcategoryId);
    }

    onChangeSubcateroty(sub: SubCategory){
        this.filterCategories(sub.id);
    }
}