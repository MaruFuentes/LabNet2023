import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { IShippers } from 'src/app/data/interfaces/shippers';
import { ShippersService } from 'src/app/data/services/shippers.service';

@Component({
  selector: 'app-shippersupdate',
  templateUrl: './shippersupdate.component.html',
  styleUrls: ['./shippersupdate.component.css']
})
export class ShippersupdateComponent implements OnInit {
  submitted: boolean = false;
  shipperForm!: FormGroup;
  error: boolean = false;
  shipperToUpdate?: IShippers;
  constructor(private formBuilder: FormBuilder, private shippersService: ShippersService, private router: Router, private activatedRoute: ActivatedRoute) { }

  ngOnInit(): void {
    const id = this.activatedRoute.snapshot.paramMap.get("id");
    if (id == null) {
      this.router.navigate(['/shippers'])
    } else {
      const idInt: number = parseInt(id);
      this.shippersService.getByID(idInt).subscribe({
        next: (resp) => {
          this.shipperToUpdate = resp;
          this.shipperForm = this.formBuilder.group({
            companyName: [this.shipperToUpdate?.companyName, [Validators.minLength(5), Validators.maxLength(40), Validators.required]],
            phone: [this.shipperToUpdate?.phone, [Validators.minLength(8), Validators.maxLength(24), Validators.required]]
          })
        },
        error: (e) => {
          this.router.navigate(['/home'])
        }
      })
    }

  }

  onSubmit() {
    this.submitted = true;
    if (this.shipperForm.invalid) {
      return;
    }
    const shipperUpdate: IShippers = { ID: this.shipperToUpdate?.ID, companyName: this.shipperForm.value.companyName, phone: this.shipperForm.value.phone }
    this.shippersService.update(shipperUpdate).subscribe({
      next: (resp) => {
        this.router.navigate(["/shippers"])
      },
      error: (e) => {
        this.error = true;
      }
    })

  }

  get validatorArray() {
    return this.shipperForm.controls
  }

  onReset() {
    this.submitted = false;
    this.shipperForm.reset();
  }

}
