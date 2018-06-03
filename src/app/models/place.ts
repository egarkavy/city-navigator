export default class Place {

    description: string;
    img: string;

    constructor(public latitude: number, public longitude: number, public category: number = 1) {

    }
}