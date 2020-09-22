import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BaseTransactionService } from 'app/base-transaction.service';
import { Observable } from 'rxjs';

@Injectable()
export class PossalesInvoiceService extends BaseTransactionService {
    constructor(http: HttpClient,
        @Inject('BASE_URL') baseUrl: string) {
        super(http, baseUrl);
    }

    addHeader<possalesheader>(item): Observable<possalesheader> {
        var url = this.baseUrl + "api/InvPOSSalesHeaders/";
        return this.http.post<possalesheader>(url, item);
    }
    editHeader<possalesheader>(item): Observable<possalesheader> {
        var url = this.baseUrl + "api/InvPOSSalesHeaders/" + item.id;
        return this.http.put<possalesheader>(url, item);
    }
    postHeader<possalesheader>(id): Observable<possalesheader> {
        var url = this.baseUrl + "api/InvPOSSalesHeaders/" + id;
        return this.http.delete<possalesheader>(url);
    }
    cancelHeader<possalesheader>(id): Observable<possalesheader> {
        var url = this.baseUrl + "api/InvPOSSalesHeaders/" + id;
        return this.http.delete<possalesheader>(url);
    }
    getDocuments(): Observable<any> {
        var url = this.baseUrl + "api/InvPOSSalesHeaders/GetDocuments";
        return this.http.get<any>(url);
    }
    navigate<possalesheader>(position, id): Observable<possalesheader> {
        var url = this.baseUrl + "api/InvPOSSalesHeaders/" + position + "/" + id;
        return this.http.get<possalesheader>(url);
    }
}