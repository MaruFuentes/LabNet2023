import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ShippersService } from 'src/app/data/services/shippers.service';
import { IShippers } from './../../../../data/interfaces/shippers';
import { Router } from '@angular/router';


@Component({
  selector: 'app-shipperscreate',
  templateUrl: './shipperscreate.component.html',
  styleUrls: ['./shipperscreate.component.css']
})
export class ShipperscreateComponent implements OnInit {
  submitted: boolean = false;
  shipperForm!: FormGroup;
  error: boolean = false;
  constructor(private formBuilder: FormBuilder, private shippersService: ShippersService, private router: Router) { }

  ngOnInit(): void {
    this.shipperForm = this.formBuilder.group({
      companyName: ['', [Validators.minLength(5), Validators.maxLength(40), Validators.required]],
      phone: ['', [Validators.minLength(8), Validators.maxLength(24), Validators.required]]
    })
  }

  onSubmit() {
    this.submitted = true;
    if (this.shipperForm.invalid) {
      return;
    }
    const shipperCreate: IShippers = { companyName: this.shipperForm.value.companyName, phone: this.shipperForm.value.phone }
    this.shippersService.create(shipperCreate).subscribe({
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

  onReset(){
    this.submitted = false;
    this.shipperForm.reset();
  }
}
