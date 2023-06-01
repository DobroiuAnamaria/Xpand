import { PlanetStatus } from './status';
import Team from './team';

export default class Planet {
  public id: number;
  public name: string;
  public description: string;
  public image: string;
  public planetStatus: PlanetStatus;
  public team: Team;

  constructor(
    id: number,
    name: string,
    description: string,
    image: string,
    status: PlanetStatus,
    team: Team
  ) {
    this.id = id;
    this.name = name;
    this.description = description;
    this.image = `./assets/${image}`;
    this.planetStatus = status;
    this.team = team;
  }
}
