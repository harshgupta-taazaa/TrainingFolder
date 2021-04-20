import { Pipe, PipeTransform } from '@angular/core';
import { IProduct } from './product/Iproduct';

@Pipe({
  name: 'productnamePipe'
})
export class ProductnamePipePipe implements PipeTransform {

  transform(value: IProduct[],args: string): IProduct[] {
    if(!args){
      return value;
    }
    return value.filter(
      item =>item.ProductName.toLowerCase().indexOf(args.toLocaleLowerCase())>-1)
    
  }
  }


