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
        var url = this.baseUrl + "api/InvPOSSalesHeaders/AddPOSSalesHeader";
        return this.http.post<possalesheader>(url, item);
    }
    editHeader<possalesheader>(item): Observable<possalesheader> {
        var url = this.baseUrl + "api/InvPOSSalesHeaders/EditPOSSalesHeader" ;
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
    getTypes(documentId): Observable<any> {
        var url = this.baseUrl + "api/InvPOSSalesHeaders/GetTypes/" + documentId;
        return this.http.get<any>(url);
    }
    addDetails<possalesDetails>(item): Observable<possalesDetails> {
        var url = this.baseUrl + "api/InvPOSSalesHeaders/AddPOSSalesDetails";
        return this.http.post<possalesDetails>(url, item);
    }
    editDetails<possalesDetails>(item): Observable<possalesDetails> {
        var url = this.baseUrl + "api/InvPOSSalesHeaders/";
        return this.http.put<possalesDetails>(url, item);
    }
    deleteDetails<possalesDetails>(id): Observable<possalesDetails> {
        var url = this.baseUrl + "api/InvPOSSalesHeaders/" + id;
        return this.http.delete<possalesDetails>(url);
    }
    getCustomers(keyword): Observable<any> {
        var url = this.baseUrl + "api/InvPOSSalesHeaders/GetCustomers/" + keyword;
        return this.http.get<any>(url);
    }
    getItems(keyword): Observable<any> {
        var url = this.baseUrl + "api/InvPOSSalesHeaders/GetItems/" + keyword;
        return this.http.get<any>(url);
    }
    GetItemUnits(itemId): Observable<any> {
        var url = this.baseUrl + "api/InvPOSSalesHeaders/GetItemUnits/" + itemId;
        return this.http.get<any>(url);
    }
    GetItemUnitPrice(itemId,unitId): Observable<any> {
        var url = this.baseUrl + "api/InvPOSSalesHeaders/GetItemUnitPrice/" + itemId + "/" + unitId;
        return this.http.get<any>(url);
    }
}