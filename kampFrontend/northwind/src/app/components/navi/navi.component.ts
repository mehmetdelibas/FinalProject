import { Component } from '@angular/core';
import { CartSummeryComponent } from '../cart-summery/cart-summery.component';

@Component({
  selector: 'app-navi',
  standalone: true,
  imports: [CartSummeryComponent],
  templateUrl: './navi.component.html',
  styleUrl: './navi.component.css',
})
export class NaviComponent {}
