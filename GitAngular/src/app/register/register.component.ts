import { Component, OnInit } from '@angular/core';
import { User } from '../shared/user';
import { DataService } from '../shared/data_service/data.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],
  providers: [DataService]
})
export class RegisterComponent implements OnInit {

  user: User;
  confirmPass: string;

  constructor(public dataService: DataService) {
    this.user = new User();
  }

  ngOnInit() {
  }
  register() {
    console.log(this.user.EmailId + '  ' + this.user.Password + '  ' + this.confirmPass);
    if (this.user.Password === this.confirmPass) {
      this.dataService.AddUser(this.user).subscribe(res => {
        console.log('Record inserted successfully');
      });
    }
  }
}
