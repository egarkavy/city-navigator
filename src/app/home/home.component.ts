import { Component } from "@angular/core";
import Place from "../models/place";
import { HttpClient } from '@angular/common/http';

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

    constructor(private http: HttpClient) {
        this.places.push(
            new Place(51.678418, 7.809007, 1),
            new Place(51.66990177064556, 7.809007, 2),
            new Place(51.67141745840093, 7.809009, 2, 3),
            new Place(51.66990177064556, 7.813079059977781, 3, 4)
        );

        this.filteredCategories = this.places.filter(x => x.category === 1);
        debugger;
        this.http.get("http://localhost:60000/api/places")
            .subscribe(places => {
                debugger;
            });
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