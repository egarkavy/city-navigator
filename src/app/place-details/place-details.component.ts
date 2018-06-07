import { Component, Input } from "@angular/core";
import Place from "../models/place";
import { ActivatedRoute } from "@angular/router"
import { HttpClient } from '@angular/common/http';

@Component({
    selector: 'place-details',
    templateUrl: './place-details.component.html',
    styleUrls: ['./place-details.component.scss']
})
export class PlaceDetails{

    placeId: Number
    place: Place;

    constructor(private activatedRoute: ActivatedRoute, private http: HttpClient) {
        activatedRoute.params.subscribe(
            params => {
                debugger;
                this.placeId = +params['id'];
            }
        );
        debugger;
        this.http.get<Place>("http://localhost:60000/api/places/",  { params: {id: this.placeId.toString() }})
        .subscribe(place => {
            debugger;
            place;
        })

    }
}