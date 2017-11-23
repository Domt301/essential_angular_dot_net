import { Injectable } from "@angular/core";
import {Product} from "./product.model";

@Injectable()
export class Cart {
    selections: ProductSelection[] = [];
    itemCount: number = 0; 
    totalPrice: number = 0;

    addProduct(product: Product){
        

    }
}