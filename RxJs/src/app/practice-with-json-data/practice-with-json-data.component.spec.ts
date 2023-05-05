import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PracticeWithJsonDataComponent } from './practice-with-json-data.component';

describe('PracticeWithJsonDataComponent', () => {
  let component: PracticeWithJsonDataComponent;
  let fixture: ComponentFixture<PracticeWithJsonDataComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PracticeWithJsonDataComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PracticeWithJsonDataComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
