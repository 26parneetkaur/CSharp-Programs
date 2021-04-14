import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VisitorPanelComponent } from './visitor-panel.component';

describe('VisitorPanelComponent', () => {
  let component: VisitorPanelComponent;
  let fixture: ComponentFixture<VisitorPanelComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ VisitorPanelComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(VisitorPanelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
