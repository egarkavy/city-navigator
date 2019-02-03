export default class Place {

    objectId: string;
    name: string;
    categoryId: any;
    location: LocationViewModel;
    tittle: string;
    shortDescription: string;
    metaDescription: string;
    advDescription: string;
    htmlContent: string;
    woringHours: string[];
    addresses: string[];
    phoneNumbers: string[];

    comments: Comment[];
}
class LocationViewModel {
    coordinates: number[];
}

class Comment {
    commentator: string;
    commentText: string;
    mark: number;
}