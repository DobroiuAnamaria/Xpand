import Robot from './robot';

export default class Captain {
  public id: number | undefined;
  public name: string;

  constructor(name: string) {
    this.name = name;
  }
}
