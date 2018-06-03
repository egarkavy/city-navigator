import { Component, Input } from "@angular/core";

@Component({
    selector: 'place-summary',
    templateUrl: './place-summary.component.html',
    styleUrls: ['./place-summary.component.scss']
})
export class PlaceSummaryComponent{ 
    
    constructor() {
        
    }

    @Input('info')
    info: any;
}