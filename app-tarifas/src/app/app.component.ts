import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { TarifasComponent } from "./tarifa/tarifa/tarifa.component";
import { MenuComponent } from "./compartido/menu/menu.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, TarifasComponent, MenuComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  titulo = 'Aplicación Calculo Tarifas Empresas';
}
