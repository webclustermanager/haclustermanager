import { Injectable } from '@angular/core';

import { environment } from 'src/environments/environment.prod';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class NodeService {
  readonly BaseURI = 'https://localhost:44390/api';
  constructor(private http: HttpClient) { }

  getNodesList() {
    return this.http.get(this.BaseURI + '/Nodes/').toPromise();
  }
}
