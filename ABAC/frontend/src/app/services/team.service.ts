import { Injectable } from '@angular/core';
import { HttpClient, HttpHandler } from '@angular/common/http';
import Team from '../models/team';

@Injectable({
  providedIn: 'root',
})
export class TeamService {
  static readonly TEAM_BASE_PATH = 'https://localhost:44383/api/teams';

  constructor(private http: HttpClient, private httpHandler: HttpHandler) {}

  getTeams() {
    return this.http.get<Team[]>(`${TeamService.TEAM_BASE_PATH}`);
  }
}
