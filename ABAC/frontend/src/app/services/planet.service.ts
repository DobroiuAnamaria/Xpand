import { Injectable } from '@angular/core';
import { HttpClient, HttpHandler } from '@angular/common/http';
import Planet from '../models/planet';

@Injectable({
  providedIn: 'root',
})
export class PlanetService {
  static readonly PLANET_BASE_PATH = 'https://localhost:44383/api/planets';

  constructor(private http: HttpClient, private httpHandler: HttpHandler) {}

  getPlanets() {
    return this.http.get<Planet[]>(`${PlanetService.PLANET_BASE_PATH}`);
  }

  updatePlanet(planet: Planet) {
    return this.http.put(`${PlanetService.PLANET_BASE_PATH}`, planet);
  }

  mapPlanet(planet: Planet) {
    return {
      id: planet.id,
      name: planet.name,
      description: planet.description,
      planetStatus: planet.planetStatus,
      teamId: planet.team.id,
    };
  }
}
