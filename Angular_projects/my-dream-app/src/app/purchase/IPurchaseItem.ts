import { IProduct } from "../product/Iproduct";

export interface IPurchaseItem{
    Id:number,
    Name:string,
    Date:string,
    Vendorname:string,
    Items:IProduct[]

}