import { Component, Input, OnInit } from '@angular/core';
import { ColDef } from 'ag-grid-community';
import { LeaveListDto } from '@shared/service-proxies/service-proxies';


@Component({
  selector: 'app-request-leave',
  templateUrl: './request-leave.component.html',
  styleUrls: ['./request-leave.component.css']
})
export class RequestLeaveComponent implements OnInit {


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
