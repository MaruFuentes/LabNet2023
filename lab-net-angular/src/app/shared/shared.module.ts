import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavbarComponent } from './components/navbar/navbar.component';
import { FooterComponent } from './components/footer/footer.component';
import { RouterModule } from '@angular/router';
import { FiltershipperPipe } from './pipes/filtershipper.pipe';




@NgModule({
  declarations: [
    NavbarComponent,
    FooterComponent,
    FiltershipperPipe
  ],
  imports: [
CommonModule,
    RouterModule
  ],
  exports: [
    NavbarComponent,
    FooterComponent,
    FiltershipperPipe
  ]
})
export class SharedModule { }
