import { Component, OnInit } from '@angular/core';
import { TarifaService } from '../tarifa.service';
import { Tarifa } from '../../Models/Tarifa';

@Component({
  selector: 'app-tarifa',
  standalone: true,
  imports: [],
  templateUrl: './tarifa.component.html',
  styleUrl: './tarifa.component.css'
})
export class TarifasComponent implements OnInit {
  tarifas:Tarifa[] = [];
  newTarifa = { desdeFecha: '', hastaFecha: '', desdeTrabajadores: 0, hastaTrabajadores: 0, importeTrabajador: 0 };

  constructor(private tarifaService: TarifaService) { }

  ngOnInit(): void {
      this.getTarifas();
  }

  getTarifas() {
      this.tarifaService.getTarifas().subscribe(data => this.tarifas = data);
  }

  addTarifa() {
      this.tarifaService.addTarifa(this.newTarifa).subscribe(() => {
          this.getTarifas();
          this.newTarifa = { desdeFecha: '', hastaFecha: '', desdeTrabajadores: 0, hastaTrabajadores: 0, importeTrabajador: 0 };
      });
  }

  deleteTarifa(id: number) {
      this.tarifaService.deleteTarifa(id).subscribe(() => this.getTarifas());
  }
}