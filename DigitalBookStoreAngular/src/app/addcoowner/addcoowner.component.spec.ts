import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddcoownerComponent } from './addcoowner.component';

describe('AddcoownerComponent', () => {
  let component: AddcoownerComponent;
  let fixture: ComponentFixture<AddcoownerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddcoownerComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddcoownerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
