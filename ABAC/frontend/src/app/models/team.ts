import Captain from './captain';
import Robot from './robot';

export default class Team {
  public id: number;
  public captain: Captain;
  public robots: Robot[];

  constructor(id: number, captain: Captain, robots: Robot[]) {
    this.id = id;
    this.captain = captain;
    this.robots = robots;
  }
}
