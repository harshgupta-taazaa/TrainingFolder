import { Pipe, PipeTransform } from '@angular/core';
import { IProduct } from './product/Iproduct';

@Pipe({
  name: 'categoryPipe'
})
export class CategoryPipePipe implements PipeTransform {

  transform(value: IProduct[],args: string): IProduct[] {
    if(!args){
      return value;
    }
    return value.filter(
      item =>item.CategoryName.toLowerCase().indexOf(args.toLocaleLowerCase())>-1)
    
  }
}
