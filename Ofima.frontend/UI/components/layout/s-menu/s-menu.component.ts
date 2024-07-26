import { CommonModule } from '@angular/common';
import {
  Component,
  EventEmitter,
  Input,
  OnInit,
  Output,
  ViewEncapsulation,
} from '@angular/core';

import { MenuItem } from 'primeng/api';
import { MenubarModule } from 'primeng/menubar';

@Component({
  standalone: true,
  selector: 'app-s-menu',
  templateUrl: './s-menu.component.html',
  imports: [MenubarModule, CommonModule],
  styleUrls: ['./s-menu.component.scss'],
  encapsulation: ViewEncapsulation.None,
})
export class SMenuComponent implements OnInit {
  @Output() eventActionSidebar = new EventEmitter<boolean>();
  @Input() items: MenuItem[] = [];
  @Input() sidebarVisible!: boolean;
  @Input() image: string;
  @Input() placeholder: string;
  @Input() greeting: string = 'Hola';
  @Input() name: string = 'Darwin Diaz';
  @Input() role: string = 'Hola';

  constructor() {
    this.placeholder = '';
    this.image = '../../../assets/img/logo.svg';
  }

  ngOnInit() {
    console.log(this.items);
  }
}
