import { Component, OnInit } from '@angular/core';
import {RouterModule} from '@angular/router';

@Component({
  selector: 'navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  isAddShift = false;
  title = 'Project_Angular';
  checkBill = 0;
  isBill = false;
  OnBill(){
    this.checkBill = 1;
    this.isBill = !this.isBill;
    this.changeAni = true;
  }
  OffBill(){
    if(this.checkBill == 1 ){
      this.checkBill = 2;
    }
    else if(this.checkBill == 2){
      this.changeAni = false;
      this.isBill = true;
      this.checkBill = 0;
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
  changeAni = true;
  ChangeAni(){
    console.log(this.isBill);
    setTimeout(() => {
      this.isBill = false;
      this.changeAni = true;
  }, 400);   
  }
}
