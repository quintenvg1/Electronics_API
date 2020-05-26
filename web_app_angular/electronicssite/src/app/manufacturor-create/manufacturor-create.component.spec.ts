import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ManufacturorCreateComponent } from './manufacturor-create.component';

describe('ManufacturorCreateComponent', () => {
  let component: ManufacturorCreateComponent;
  let fixture: ComponentFixture<ManufacturorCreateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ManufacturorCreateComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ManufacturorCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
