import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { UserService } from '../shared/user.service';

@Component({
  selector: 'app-addcoowner',
  templateUrl: './addcoowner.component.html',
  styleUrls: ['./addcoowner.component.css']
})
export class AddcoownerComponent implements OnInit {

  constructor(public  service:UserService,private toastr:ToastrService) { }

  ngOnInit(): void {
    this.service.formModel.reset();
  }

  onSubmit(){
    this.service.addCoOwner().subscribe(
      (res:any)=>{
        if(res.succeeded)
        {
          this.service.formModel.reset();
          this.toastr.success('New Coowner Added','Registration successful.');
        }
        else{
          res.errors.forEach((element: any) => {
            switch(element.code){
              case 'DuplicateUserName':
                this.toastr.error('Owner or Username is already taken','Registration Failed');
                //username is already taken
                break;
                default:
                  this.toastr.error(element.code,'Registration Failed');
                  //registration failed
                  break;
            }

          });
          
          
        }
      },
      err=>{
        console.log(err);
      }
    );
  }
}
