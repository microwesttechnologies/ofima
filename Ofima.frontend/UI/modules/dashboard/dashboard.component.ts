import { Component, OnInit } from '@angular/core';
import { GetAllMenuUseCases } from 'Core/Domain/UseCase/GetAllMenuUseCase';
import { MenuItem } from 'primeng/api';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss'],
})
export class DashboardComponent implements OnInit {
  items: MenuItem[] = [];
  cards: any[] = [];
  
  
  constructor(private _getAllMenuUseCase: GetAllMenuUseCases) {
    this.cards=[
      {
        title:"Ingreso al CRM", 
        subtitle:"En este modulo encontraras todo las capacitaciones referentes al CRM y sus componentes adicionales",
        image: "../assets/img/card_1.jpg"
      },
      {
        title:"Gestion humana", 
        subtitle:"En este modulo encontraras todo lo relacionado con incapacidades, ausentismos, novedades y mucho mas",
        image: "../assets/img/card_2.png"
      },
      {
        title:"Sistema medico", 
        subtitle:"Conosca todo lo relacionado con los deberes y derechos que tendras con respecto a tu sistema medico",
        image: "../assets/img/card_3.jpeg"
      },
    ]
  }

  GetAllMenu() {
    this._getAllMenuUseCase.getAllMenu()
      .subscribe(
        data => {
          console.log('Datos recibidos:', data);
          this.items = this.transformResponseToMenuItems(data);
          console.log('Items transformados:', this.items);
        },
        error => {
          console.error('Error al obtener los menús:', error);
        }
      );
  }
  

  ngOnInit(): void {
    this.GetAllMenu();
  }

  transformResponseToMenuItems(data: any): MenuItem[] {
    if (!data || !Array.isArray(data.$values)) {
      console.error('Data o $values no es un array:', data);
      return [];
    }
  
    return data.$values.map((category: any) => ({
      label: category.name_category,
      icon: 'pi pi-fw pi-folder',
      items: category.subcategory_menu?.$values?.map((subcategory: any) => ({
        label: subcategory.name_subcategory,
        icon: 'pi pi-fw pi-file',
        items: subcategory.submenu_menu?.$values?.map((submenu: any) => ({
          label: submenu.name_submenu,
          icon: 'pi pi-fw pi-check',
          items: submenu.finalmenu_menu?.$values?.map((finalmenu: any) => ({
            label: finalmenu.name_finalmenu,
            icon: 'pi pi-fw pi-check'
          })) || []
        })) || []
      })) || []
    })) || [];
  }
  
}
