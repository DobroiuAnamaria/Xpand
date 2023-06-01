import { Component, OnInit } from '@angular/core';
import { PlanetService } from './services/planet.service';
import Planet from './models/planet';
import { TeamService } from './services/team.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  title = 'frontend';
  planets: Planet[] = [];

  selectedPlanet: Planet | undefined;

  planetStatusOptions = ['OK', '!OK', 'TODO', 'En Route'];

  listMode = true;

  constructor(
    private planetService: PlanetService,
    private teamService: TeamService
  ) {}

  ngOnInit(): void {
    this.getPlanets();
  }

  getPlanets() {
    this.planetService.getPlanets().subscribe((data: Planet[]) => {
      this.planets = data;
      console.log(data);
    });
  }

  onClick(event: any) {
    this.listMode = false;
    this.selectedPlanet = event;
  }

  onSubmit() {
    this.selectedPlanet!.planetStatus = this.planetStatusOptions.indexOf(
      this.selectedPlanet!.planetStatus.toString()
    );
    this.listMode = true;

    this.planetService
      .updatePlanet(this.selectedPlanet!)
      .subscribe((data: any) => {});
  }

  isSelected(status: string): boolean {
    // if (this.selectedPlanet) console.log(this.selectedPlanet.planetStatus);
    const statuss = this.selectedPlanet?.planetStatus;
    console.log(statuss == this.planetStatusOptions.indexOf(status));
    return statuss == this.planetStatusOptions.indexOf(status);
  }
}
