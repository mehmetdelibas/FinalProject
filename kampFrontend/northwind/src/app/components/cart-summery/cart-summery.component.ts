import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CartItem } from '../../models/cartItem';
import { CartService } from '../../services/cart.service';
import { Product } from '../../models/product';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-cart-summery',
  standalone: true,
  templateUrl: './cart-summery.component.html',
  styleUrl: './cart-summery.component.css',
  imports: [CommonModule],
})
export class CartSummeryComponent {
  cartItems: CartItem[] = [];
  constructor(
    private cartService: CartService,
    private toastrService: ToastrService,
  ) {}

  ngOnInit(): void {
    this.getCart();
  }

  getCart() {
    this.cartItems = this.cartService.list();
  }

  removeFromCart(prdouct: Product) {
    this.cartService.removeFromCart(prdouct);
    this.toastrService.error(prdouct.productName + ' sepetten Silindi');
  }
}
