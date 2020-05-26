import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ManufacturorRemoveComponent } from './manufacturor-remove.component';

describe('ManufacturorRemoveComponent', () => {
  let component: ManufacturorRemoveComponent;
  let fixture: ComponentFixture<ManufacturorRemoveComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ManufacturorRemoveComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ManufacturorRemoveComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
