import { Component, Input } from "@angular/core";
import { Category, SubCategory } from "../models/category";

@Component({
    selector: 'categories',
    templateUrl: './categories.component.html',
    styleUrls: ['./categories.component.scss']
})
export class CategoriesComponent{ 
    activeCategory: Category;
    activeSubCategory: SubCategory;

    constructor() {

    }

    @Input()
    onSubcategorySelect: Function

    fireSubCategory() {
        this.onSubcategorySelect(SubCategory);
    }
}