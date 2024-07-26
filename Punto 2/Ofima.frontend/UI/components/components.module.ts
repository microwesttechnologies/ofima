import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SButtonComponent } from './forms/s-button/s-button.component';
import { STableComponent } from './forms/s-table/s-table.component';
import { SCardComponent } from './forms/s-card/s-card.component';
import { STextareaComponent } from './forms/s-textarea/s-textarea.component';
import { SCalenderComponent } from './forms/s-calender/s-calender.component';
import { SMenuComponent } from './layout/s-menu/s-menu.component';



@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    SButtonComponent,
    STableComponent,
    SCardComponent,
    STextareaComponent,
    SCalenderComponent,
    SMenuComponent
  ],
  exports: [
    CommonModule,
    SButtonComponent,
    STableComponent,
    SCardComponent,
    STextareaComponent,
    SCalenderComponent,
    SMenuComponent
  ]
})
export class ComponentsModule { }
