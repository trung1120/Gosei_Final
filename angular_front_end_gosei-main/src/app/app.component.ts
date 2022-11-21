import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  submit(f: NgForm) {
    // value of the submitted form can be accessed here
  const data = f.value;
  }
  isAddShift = false;
  title = 'Project_Angular';
  checkBill = 1;
  isBill = false;
  OnBill(){
    this.checkBill = 1;
    this.isBill = !this.isBill;
  }
  OffBill(){
    if(this.checkBill % 2 == 1 ){
      this.checkBill = 2;
    }else{
      this.isBill = false;
    }
  }
  isLogout = false;
  checkLogout = 1;
  IsLogout(){
    this.checkLogout = 1;
    this.isLogout = !this.isLogout;
  }

  OffLogout(){
    if(this.checkLogout % 2 == 1){
      this.checkLogout = 2;
    }else{
      this.isLogout = false;
    }
  }

  changeColorLogout = true;
  ChangeColorLogout(){
    this.changeColorLogout = !this.changeColorLogout;
  }
  
}
