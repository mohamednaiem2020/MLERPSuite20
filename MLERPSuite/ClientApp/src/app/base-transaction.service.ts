﻿import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';


@Injectable()
export abstract class BaseTransactionService {
    constructor(protected http: HttpClient,
        protected baseUrl: string) {

    }
    abstract addHeader<T>(item: T): Observable<T>;
    abstract editHeader<T>(item: T): Observable<T>;
    abstract postHeader<T>(id: number): Observable<T>;
    abstract cancelHeader<T>(id: number): Observable<T>;
    abstract navigate<T>(postion: string, id: number): Observable<T>;
    abstract getDocuments<T>(): Observable<T>;
    abstract getTypes<T>(documentId: number): Observable<T>;
    abstract addDetails<T>(item: T): Observable<T>;
    abstract editDetails<T>(item: T): Observable<T>;
    abstract deleteDetails<T>(id: number): Observable<T>;
    abstract getDetails<T>(transId: number): Observable<T>;
}