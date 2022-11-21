import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ComponentLeaveComponent } from './component-leave.component';

describe('ComponentLeaveComponent', () => {
  let component: ComponentLeaveComponent;
  let fixture: ComponentFixture<ComponentLeaveComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ComponentLeaveComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ComponentLeaveComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
