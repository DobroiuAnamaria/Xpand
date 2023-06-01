import { Component, EventEmitter, Input, Output } from '@angular/core';
import Planet from 'src/app/models/planet';
import Robot from 'src/app/models/robot';
import { PlanetStatus } from 'src/app/models/status';

@Component({
  selector: 'app-planet-details',
  templateUrl: './planet-details.component.html',
  styleUrls: ['./planet-details.component.css'],
})
export class PlanetDetailsComponent {
  @Input() planet: Planet | undefined;
  @Output() click = new EventEmitter<any>();

  getStatusColorClass() {
    switch (this.planet?.planetStatus) {
      case PlanetStatus.OK:
        return 'green';
      case PlanetStatus.NOK:
        return 'red';
      case PlanetStatus.TODO:
      case PlanetStatus.EN_ROUTE:
        return 'grey';
      default:
        return '';
    }
  }

  get robots() {
    if (!this.planet || !this.planet?.team.captain) {
      return '';
    }

    var robots = '';
    this.planet?.team?.robots.forEach((robot: Robot) => {
      robots = robots.length === 0 ? robot.name : `${robots}, ${robot.name}`;
      if (robots.length === 0) {
        robots = robot.name;
      }
    });

    return robots;
  }

  get description() {
    return this.planet?.description
      ? `"${this.planet?.description}"`
      : 'No description yet :/';
  }

  get image() {
    return `./assets/${this.planet?.image}`;
  }

  get status() {
    if (!this.planet) {
      return '';
    }

    return ['OK', '!OK', 'TODO', 'En Route'][this.planet.planetStatus];
  }

  onClick(event: any) {
    event.preventDefault();
    event.stopPropagation();
    this.click.emit(this.planet);
  }
}
