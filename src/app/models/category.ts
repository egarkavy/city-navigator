export class Category {
    id: string;
    name: string;

    subcategories: SubCategory[];
}

export class SubCategory {
    id: string;
    name: string;
    categoryId: string;
}