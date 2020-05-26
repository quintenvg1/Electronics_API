import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ManufacturorpageComponent } from './manufacturorpage.component';

describe('ManufacturorpageComponent', () => {
  let component: ManufacturorpageComponent;
  let fixture: ComponentFixture<ManufacturorpageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ManufacturorpageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ManufacturorpageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
