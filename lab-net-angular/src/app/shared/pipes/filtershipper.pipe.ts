import { Pipe, PipeTransform } from '@angular/core';
import { IShippers } from './../../data/interfaces/shippers';

@Pipe({
  name: 'filtershipper'
})
export class FiltershipperPipe implements PipeTransform {

  transform(value: IShippers[], filter: string): IShippers[] {
    if(filter == '' || filter == undefined){
      return value;
    }
    return value.filter(v => v.companyName.toUpperCase().includes(filter.toUpperCase()));
  }

}
