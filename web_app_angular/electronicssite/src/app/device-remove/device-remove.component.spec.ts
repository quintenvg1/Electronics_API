import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DeviceRemoveComponent } from './device-remove.component';

describe('DeviceRemoveComponent', () => {
  let component: DeviceRemoveComponent;
  let fixture: ComponentFixture<DeviceRemoveComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DeviceRemoveComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DeviceRemoveComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
