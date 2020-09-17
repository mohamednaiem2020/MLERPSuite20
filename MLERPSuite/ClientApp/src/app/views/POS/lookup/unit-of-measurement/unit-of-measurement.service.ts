import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BaseLookupService} from 'app/base-lookup.service'
import { Observable } from 'rxjs';

@Injectable()
export class UnitOfMeasurementService extends BaseLookupService{
    constructor(http: HttpClient,
        @Inject('BASE_URL') baseUrl: string) {
        super(http, baseUrl);
    }

    get<UnitOfMeasurement>(id): Observable<UnitOfMeasurement> {
        var url = this.baseUrl + "api/UnitsOfMeasurement/" + id;
        return this.http.get<UnitOfMeasurement>(url);
    }
    put<UnitOfMeasurement>(item): Observable<UnitOfMeasurement> {
        var url = this.baseUrl + "api/UnitsOfMeasurement/" + item.id;
        return this.http.put<UnitOfMeasurement>(url, item);
    }
    post<UnitOfMeasurement>(item): Observable<UnitOfMeasurement> {
        var url = this.baseUrl + "api/UnitsOfMeasurement";
        return this.http.post<UnitOfMeasurement>(url, item);
    }
    delete<UnitOfMeasurement>(id): Observable<UnitOfMeasurement> {
        var url = this.baseUrl + "api/UnitsOfMeasurement/" + id;
        return this.http.delete<UnitOfMeasurement>(url);
    }
    navigate<UnitOfMeasurement>(position,id): Observable<UnitOfMeasurement> {
        var url = this.baseUrl + "api/UnitsOfMeasurement/" + position + "/" + id;
        return this.http.get<UnitOfMeasurement>(url);
    }
}