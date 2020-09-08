/// <reference path="../../../../../../node_modules/@types/jasmine/index.d.ts" />
import { TestBed, async, ComponentFixture, ComponentFixtureAutoDetect } from '@angular/core/testing';
import { BrowserModule, By } from "@angular/platform-browser";
import { MainBoardComponent } from './main-board.component';

let component: MainBoardComponent;
let fixture: ComponentFixture<MainBoardComponent>;

describe('MainBoard component', () => {
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [ MainBoardComponent ],
            imports: [ BrowserModule ],
            providers: [
                { provide: ComponentFixtureAutoDetect, useValue: true }
            ]
        });
        fixture = TestBed.createComponent(MainBoardComponent);
        component = fixture.componentInstance;
    }));

    it('should do something', async(() => {
        expect(true).toEqual(true);
    }));
});