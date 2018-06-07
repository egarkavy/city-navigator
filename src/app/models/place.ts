export default class Place {

    description: string;
    img: string;

    constructor(public latitude: number, public longitude: number, public id = 1, public category: number = 1, public name: string = "test") {

    }
}