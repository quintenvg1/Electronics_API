import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ManufacturorUpdateComponent } from './manufacturor-update.component';

describe('ManufacturorUpdateComponent', () => {
  let component: ManufacturorUpdateComponent;
  let fixture: ComponentFixture<ManufacturorUpdateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ManufacturorUpdateComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ManufacturorUpdateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
