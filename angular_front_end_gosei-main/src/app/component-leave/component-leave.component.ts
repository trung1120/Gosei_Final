import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'component-leave',
  templateUrl: './component-leave.component.html',
  styleUrls: ['./component-leave.component.css']
})
export class ComponentLeaveComponent implements OnInit {
[x: string]: any;

  constructor() { }
  isPopup = false;
  isAll = false;
  ngOnInit(): void {
  }

  Popup() {
    this.isPopup = !this.isPopup;
  }

  addAll(): void {
    this.isAll = !this.isAll;
  }
}
