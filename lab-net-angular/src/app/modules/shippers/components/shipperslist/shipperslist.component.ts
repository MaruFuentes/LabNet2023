import { Component, OnInit } from '@angular/core';
import { IShippers } from 'src/app/data/interfaces/shippers';
import { ShippersService } from 'src/app/data/services/shippers.service';
import {faTrash, faPen} from '@fortawesome/free-solid-svg-icons';
@Component({
  selector: 'app-shipperslist',
  templateUrl: './shipperslist.component.html',
  styleUrls: ['./shipperslist.component.css']
})

export class ShipperslistComponent implements OnInit {
  faPen = faPen;
  faTrash = faTrash;
  shippersList: Array<IShippers> = [];
  message: string = '';
  filterValue: string = '';
  idToDelete?: number; 
  constructor(private shippersService: ShippersService) { }

  ngOnInit(): void {
    this.shippersService.getAll().subscribe((resp: Array<IShippers>) => {
      this.shippersList = resp;
    })
  }

  delete(id?: number){
    if(id){
      this.shippersService.delete(id).subscribe({
        next: (resp) => {
          this.message = resp;
          this.closeDeleteConfirmation();
          this.ngOnInit();
        },
        error: (e) => {
          this.message = 'Hubo un error al eliminar el shipper';
        }
      })
    }
  }

  openDeleteConfirmation(id?: number){
    if(id){
      this.idToDelete = id;
    }
  }

  closeDeleteConfirmation(){
    this.idToDelete = undefined;
  }
}
