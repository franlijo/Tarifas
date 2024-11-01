import { Routes } from '@angular/router';
import { TarifasComponent } from './tarifa/tarifa/tarifa.component';
import { EmpresaComponent } from './empresa/empresa/empresa.component';


export const routes: Routes = [
    {path: 'tarifa/tarifa', component: TarifasComponent},
    {path: 'empresa/empresa', component: EmpresaComponent},
    {path: '**', redirectTo: ''},
];
