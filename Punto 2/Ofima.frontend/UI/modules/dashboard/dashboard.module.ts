import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ButtonModule } from 'primeng/button';
import { CalendarModule } from 'primeng/calendar';
import { DialogModule } from 'primeng/dialog';
import { ImageModule } from 'primeng/image';
import { InputSwitchModule } from 'primeng/inputswitch';
import { InputTextModule } from 'primeng/inputtext';
import { ToastModule } from 'primeng/toast';
import { ComponentsModule } from 'UI/components/components.module';
import { GetAllMenuGateway } from 'Core/Domain/Gateway/GetAllMenu.Gateway'; 
import { MessageService } from 'primeng/api';
import { DashboardComponent } from './dashboard.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { GetAllMenuService } from 'Core/Infraestructura/driver-adapter/Services/GetAllMenu.service';

@NgModule({
  declarations: [DashboardComponent],
  imports: [
    CommonModule,
    ComponentsModule,
    DialogModule,
    ButtonModule,
    BrowserAnimationsModule,
    InputTextModule,
    FormsModule,
    CalendarModule,
    InputSwitchModule,
    HttpClientModule, 
    ReactiveFormsModule,
    ImageModule,
    ToastModule
  ],
  exports: [DashboardComponent],
  providers: [ 
    {provide: GetAllMenuGateway, useClass: GetAllMenuService},
    {provide: MessageService},
  ],
})
export class DashboardModule { }
