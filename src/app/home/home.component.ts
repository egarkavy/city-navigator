import { Component } from "@angular/core";
import Place from "../models/place";

@Component({
    selector: 'home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.scss']
})
export class HomeComponent{ 
    latitude: number = 51.678418;
    longitude: number = 7.809007;
    map: any;
    places: Place[] = [];

    filteredCategories: Place[] = [];

    constructor() {
        this.places.push(
            new Place(51.678418, 7.809007),
            new Place(51.66990177064556, 7.809007),
            new Place(51.67141745840093, 7.809009, 2),
            new Place(51.66990177064556, 7.813079059977781, 3)
        );

        this.filteredCategories = this.places.filter(x => x.category === 1)
    }

    mapClick($event) {
        var t = this.map;
        debugger;
    }

    onPlaceCkick(place) {
        var t = this.map;
        debugger;
    }
}