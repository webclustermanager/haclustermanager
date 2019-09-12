import { Injectable } from '@angular/core';
import { HttpClient, HttpParams, HttpHeaders } from '@angular/common/http';
import { Resource } from './resource.model';
import { BehaviorSubject, Observable, throwError } from 'rxjs';
import { FormGroup, FormControl } from '@angular/forms';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json',
    'Authorization': 'my-auth-token'
  })
};

@Injectable({
  providedIn: 'root'
})
export class ResourceService {



  private _resources: BehaviorSubject<Resource[]>;
  private dataResources: {
    resources: Resource[];
  }
  form: FormGroup = new FormGroup({
    $key: new FormControl(null),

  });

  readonly BaseURI = 'https://localhost:44390/api';
  constructor(private http: HttpClient) {
    this.dataResources = { resources: [] };
    this._resources = new BehaviorSubject<Resource[]>([]);
  }

  get resources(): Observable<Resource[]> {
    return this._resources.asObservable();
  }

  loadAll() {

    return this.http.get<Resource[]>(this.BaseURI + '/Resources/')
      .subscribe(data => {
        this.dataResources.resources = data;
        this._resources.next(Object.assign({}, this.dataResources).resources);
      },
        error => {
          console.log("Failed to load cluster resources");
        });
  }

  migrate(resource: string, node: string) {
    debugger;
    const params = new HttpParams()
      .set('id', resource)
      .set('node', node);

    return this.http.put(this.BaseURI + '/Resources/Move', { params })
  }

  delete(resource: Resource) {
    const params = new HttpParams().set('id', resource.Name);

    return this.http.delete(this.BaseURI + '/Resources/Delete', { params })
  }

  add(resource: Resource) {
    return this.http.post(this.BaseURI + '/Resources/Post', resource)
  }

  update(resource: Resource) {
    return this.http.put(this.BaseURI + '/Resources/Update', resource)
  }

}

