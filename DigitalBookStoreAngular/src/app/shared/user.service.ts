import { Injectable } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private fb:FormBuilder,private http:HttpClient) { }
  readonly BaseURI="https://localhost:44306/api";
  formModel=this.fb.group({
    Username:['',Validators.required],
    Email:['',Validators.email],
    FullName:[''],
    Passwords:this.fb.group({
      Password:['',[Validators.required,Validators.minLength(4)]],
      ConfirmPassword:['',Validators.required]
    },{validator:this.comparePasswords})
   
  });
  comparePasswords(fb:FormGroup){
    let confirmPasswdCtrl:any=fb.get('ConfirmPassword');
    //passwordmismatch
    //confirmPasswdCtrl.errors={required:true}
    // if(confirmPasswdCtrl.errors==null || 'passwordMisMatch' in confirmPasswdCtrl.errors){
    //   if(fb.get('Password').value!=confirmPasswdCtrl.value)
    //   {
    //     confirmPasswdCtrl.setErrors({passwordMisMatch:true});
        
    //   }
    //   else
    //     confirmPasswdCtrl.setErrors(null);
    // }
  }
  register()
  {
    var body={
      Username:this.formModel.value.Username,
      Email:this.formModel.value.Email,
      Password:this.formModel.value.Passwords.Password,
      FullName:this.formModel.value.FullName
      
      
    };
      return this.http.post(this.BaseURI+'/BookStore/Register',body);
  }

  addCoOwner()
  {
    var body={
      Username:this.formModel.value.Username,
      Email:this.formModel.value.Email,
      Password:this.formModel.value.Passwords.Password,
      FullName:this.formModel.value.FullName
      
      
    };
      return this.http.post(this.BaseURI+'/BookStore/AddCoOwner',body);
  }
  get f()
{
    return this.formModel.controls;
}
login(formData:any)
{
  return this.http.post(this.BaseURI+'/BookStore/Login',formData);
}
getUserProfile()
{
  return this.http.get(this.BaseURI+'/UserProfile');
}

roleMatch(allowedRoles: any):boolean{
  var local:any=localStorage.getItem('token');
  //var localStorage:any;
  var isMatch=false;
  var payload=JSON.parse(window.atob(local.split('.')[1]));
  var userRole=payload.role;
  allowedRoles.forEach((element: any) => {
    if (userRole == element) {
      isMatch = true;
     
    }
    return false;
  });
  return isMatch;
}
}
