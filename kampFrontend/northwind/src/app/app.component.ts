import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, CommonModule],
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title: string = 'northwind';
  user: string = 'Mehmet Metin';
  product1: any = {
    productId: 1,
    productName: 'Bardak',
    categoryId: 1,
    unitPrice: 5,
  };
  product2: any = {
    productId: 1,
    productName: 'Laptop',
    categoryId: 1,
    unitPrice: 5,
  };
  product3: any = {
    productId: 1,
    productName: 'Tava',
    categoryId: 1,
    unitPrice: 5,
  };
  product4: any = {
    productId: 1,
    productName: 'Kutu',
    categoryId: 1,
    unitPrice: 5,
  };
  product5: any = {
    productId: 1,
    productName: 'Anahtar',
    categoryId: 1,
    unitPrice: 5,
  };

  products = [
    this.product1,
    this.product2,
    this.product3,
    this.product4,
    this.product5,
  ];
}
