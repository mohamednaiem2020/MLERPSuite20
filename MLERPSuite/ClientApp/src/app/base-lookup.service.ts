import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export abstract class BaseLookupService {
    constructor(protected http: HttpClient,
        protected baseUrl: string) {
    }
    abstract get<T>(id: number): Observable<T>;
    abstract put<T>(item: T): Observable<T>;
    abstract post<T>(item: T): Observable<T>;
    abstract delete<T>(id: number): Observable<T>;
}
