import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-request-leave',
  templateUrl: './request-leave.component.html',
  styleUrls: ['./request-leave.component.css']
})
export class RequestLeaveComponent implements OnInit {

  checkRoster = true;
  checkAvai = false;
  checkLeave = false;
  changeCalendar = 1;
  constructor() { }

  LeaveButton() {
    this.changeCalendar = 3;
    this.checkLeave = true;
    this.checkRoster = false;
    this.checkAvai = false;
  }
  ngOnInit(): void {
  }

}
