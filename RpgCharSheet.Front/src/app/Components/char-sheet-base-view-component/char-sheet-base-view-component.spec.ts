import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CharSheetBaseViewComponent } from './char-sheet-base-view-component';

describe('CharSheetBaseViewComponent', () => {
  let component: CharSheetBaseViewComponent;
  let fixture: ComponentFixture<CharSheetBaseViewComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CharSheetBaseViewComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CharSheetBaseViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
