import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { TarifasComponent } from "./tarifa/tarifa/tarifa.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, TarifasComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  titulo = 'Hola Mundo desde Angular';
}
