import { Component } from '@angular/core';
import { ColDef } from 'ag-grid-community';

@Component({
  selector: 'app-week',
  templateUrl: './week.component.html',
  styleUrls: ['./week.component.css']
})
export class WeekComponent {
  days: any[] = [1, 2, 3, 4, 5, 6, 7];
  weekday: any[] = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];
  dateNow: Date = new Date;
  dateEnd = "";
  dateStart = "";
  n = this.dateNow.getDay();
  checkWeek = 0;
  status = "This Week";
  LeftRightButton(n: number) {
    if (n == 1) {
      this.dateNow.setDate(this.dateNow.getDate() + 7);
      this.checkWeek++;
    }
    if (n == -1) {
      this.dateNow.setDate(this.dateNow.getDate() - 7);
      this.checkWeek--;
    }
    this.ngOnInit();
    if (this.checkWeek == 1) this.status = "Next Week";
    else if (this.checkWeek == 0) this.status = "This Week";
    else if (this.checkWeek > 1 || this.checkWeek < -1) this.status = this.dateStart + " - " + this.dateEnd;
    else if (this.checkWeek == -1) this.status = "Last Week";
  }
  ngOnInit(): void {
    this.setRowData();
    for (let i = 0; i < this.days.length; i++) {

      if (this.dateNow.getDay() == 0) {
        this.n = 7;
      } else {
        this.n = this.dateNow.getDay();
      }
      this.dateNow.setDate(this.dateNow.getDate() - this.n + i + 1);
      if (i == 0) {
        this.dateStart = this.dateNow.getDate() + "/" + (this.dateNow.getMonth() + 1) + "/" + this.dateNow.getFullYear();
      }
      if (i == 6) {
        this.dateEnd = this.dateNow.getDate() + "/" + (this.dateNow.getMonth() + 1) + "/" + this.dateNow.getFullYear();
      }

      this.days[i] = this.weekday[this.dateNow.getDay()] + " " + this.dateNow.getDate();
    }

  }
  public defaultColDef: ColDef = {
    sortable: true,
    filter: true,
  };
  dateR: Date = new Date();
  dateExtra = new Date()
  public rowData: any[] = [];
  setRowData() {
    for (var i = 0; i < 15; i++) {
      this.dateExtra.setDate(this.dateR.getDate() + 1);
      this.rowData[i] = {
        LeaveType: 'Annual Leave', 
        FromDate: this.dateR.toLocaleDateString('en-GB') + " " + this.dateExtra.getHours() + ":" + this.dateExtra.getMinutes(), 
        ToDate: this.dateExtra.toLocaleDateString('en-GB')+ " " + this.dateExtra.getHours() + ":" + this.dateExtra.getMinutes(),
        Status: 'Approved'
      };
      this.dateR.setDate(this.dateR.getDate() + 1);
    }
  }
}
