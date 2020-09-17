import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export abstract class BaseLookupService {
    constructor(protected http: HttpClient,
        protected baseUrl: string) {
    }
    abstract add<T>(item: T): Observable<T>;
    abstract edit<T>(item: T): Observable<T>;
    abstract delete<T>(id: number): Observable<T>;
    abstract navigate<T>(postion:string,id: number): Observable<T>;
}
