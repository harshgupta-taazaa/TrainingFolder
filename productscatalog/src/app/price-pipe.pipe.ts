import { Pipe, PipeTransform } from '@angular/core';
import { IProduct } from './product/Iproduct';

@Pipe({
  name: 'pricePipe'
})
export class PricePipePipe implements PipeTransform {

  transform(value: IProduct[],args: number): IProduct[]{
    if(!args){
      return value;
    }
    return value.filter(
     item =>item.Price>=args)

    
  }

}
