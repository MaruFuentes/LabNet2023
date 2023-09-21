import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IShippers } from './../interfaces/shippers';
import { environment } from './../../../environments/environment';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ShippersService {

  api: string = environment.api;
  endpoint: string = 'api/Shippers';

  constructor(private httpClient: HttpClient) { }

  public getAll(): Observable<Array<IShippers>> {
    return this.httpClient.get<Array<IShippers>>(`${this.api}${this.endpoint}`);
  }

  public create(shipper: IShippers): Observable<IShippers>{
    return this.httpClient.post<IShippers>(`${this.api}${this.endpoint}`, shipper);
  }

  public update(shipper: IShippers): Observable<string>{
    return this.httpClient.put<string>(`${this.api}${this.endpoint}/${shipper.ID}`, shipper);
  }

  public delete(id: number): Observable<string>{
    return this.httpClient.delete<string>(`${this.api}${this.endpoint}/${id}`);
  }

  public getByID(id: number): Observable<IShippers>{
    return this.httpClient.get<IShippers>(`${this.api}${this.endpoint}/${id}`);
  }
}
