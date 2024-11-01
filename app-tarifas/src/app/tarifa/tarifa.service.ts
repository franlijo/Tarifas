import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

interface Tarifa {
    id?: number;
    desdeFecha: string;
    hastaFecha: string;
    desdeTrabajadores: number;
    hastaTrabajadores: number;
    importeTrabajador: number;
}

@Injectable({
    providedIn: 'root'
})
export class TarifaService {
    private apiUrl = 'http://localhost:5000/api/tarifas';

    constructor(private http: HttpClient) { }

    getTarifas(): Observable<Tarifa[]> {
        return this.http.get<Tarifa[]>(this.apiUrl);
    }

    addTarifa(tarifa: Tarifa): Observable<Tarifa> {
        return this.http.post<Tarifa>(this.apiUrl, tarifa);
    }

    updateTarifa(id: number, tarifa: Tarifa): Observable<void> {
        return this.http.put<void>(`${this.apiUrl}/${id}`, tarifa);
    }

    deleteTarifa(id: number): Observable<void> {
        return this.http.delete<void>(`${this.apiUrl}/${id}`);
    }
}

