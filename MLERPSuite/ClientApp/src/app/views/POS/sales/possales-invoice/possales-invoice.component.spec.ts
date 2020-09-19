/// <reference path="../../../../../../../node_modules/@types/jasmine/index.d.ts" />
import { TestBed, async, ComponentFixture, ComponentFixtureAutoDetect } from '@angular/core/testing';
import { BrowserModule, By } from "@angular/platform-browser";
import { PossalesInvoiceComponent } from './possales-invoice.component';

let component: PossalesInvoiceComponent;
let fixture: ComponentFixture<PossalesInvoiceComponent>;

describe('POSSalesInvoice component', () => {
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [ PossalesInvoiceComponent ],
            imports: [ BrowserModule ],
            providers: [
                { provide: ComponentFixtureAutoDetect, useValue: true }
            ]
        });
        fixture = TestBed.createComponent(PossalesInvoiceComponent);
        component = fixture.componentInstance;
    }));

    it('should do something', async(() => {
        expect(true).toEqual(true);
    }));
});