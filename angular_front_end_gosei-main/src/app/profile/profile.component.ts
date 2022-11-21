import { Component, OnInit } from '@angular/core';
import { CssClassApplier } from 'ag-grid-community';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {

  constructor(private toastr: ToastrService) { }
 
  ngOnInit(): void {
  }
  isAddShift = false;
  title = 'Project_Angular';
  addShift() {
    this.isAddShift = !this.isAddShift;
    return this.isAddShift;
  }
  days = [
    ['Sun', false],
    ['Mon', false],
    ['Tue', false],
    ['Wed', false],
    ['Thu', false],
    ['Fri', false],
    ['Sat', false],
  ]
  activeAll = false;
  isAllActive() {
    this.activeAll = !this.activeAll
    for (let i = 0; i < this.days.length; i++) {
      if (this.days[i][1] != this.activeAll) this.days[i][1] = !this.days[i][1]
    }
  }
  isActive(day: any) {
    for (let i = 0; i < this.days.length; i++) {
      if (this.days[i] === day) {
        this.days[i][1] = !this.days[i][1];
      }
    };
    for (let i = 0; i < this.days.length; i++) {
      if (!this.days[i][1]) this.activeAll = false;
    };

  }
  signIn(credentials: any) { }
  ShowSuccess(){
    this.toastr.success('<div class="save-success"> <div class="hehe" style="background-color:white;position: absolute;right: 10px;border: 1px solid #80808047;height: 40px;width: 180px;padding-top: 10px;padding-left: 16px;border-radius: 10px;"> <div role="status" aria-live="polite" class="go3958317564"><i class="bi bi-check"></i>Saved Successfully</div></div> </div>','',{
      enableHtml : true
    });
}

}
