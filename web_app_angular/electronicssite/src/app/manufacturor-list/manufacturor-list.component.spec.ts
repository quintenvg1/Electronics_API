import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ManufacturorListComponent } from './manufacturor-list.component';

describe('ManufacturorListComponent', () => {
  let component: ManufacturorListComponent;
  let fixture: ComponentFixture<ManufacturorListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ManufacturorListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ManufacturorListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
