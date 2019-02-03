import { Component, Input, Output, EventEmitter } from "@angular/core";
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

    @Output()
    onSubcategorySelect = new EventEmitter<SubCategory>();

    @Input()
    categories: Category[]

    fireSubCategory() {
        var t = this.activeCategory;
        this.onSubcategorySelect.emit(this.activeSubCategory);
    }
}