import { Routes } from "@angular/router";
import { HomeComponent } from "./home/home.component"
import { PlaceDetailsComponent } from "./place-details/place-details.component";

export const routes: Routes = [
    {
        path: "",
        component: HomeComponent,
        pathMatch: "full"
    },
    {
        path: "home",
        component: HomeComponent
    },
    {
        path: "place-details/:id",
        component: PlaceDetailsComponent
    }

];