import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddbookComponent } from './addbook/addbook.component';
import { AddcoownerComponent } from './addcoowner/addcoowner.component';
import { AdminPanelComponent } from './admin-panel/admin-panel.component';
import { AuthGuard } from './auth/auth.guard';
import { CommentsComponent } from './comments/comments.component';
import { HomeComponent } from './home/home.component';
import { UpdatebookComponent } from './updatebook/updatebook.component';
import { UploadimageComponent } from './uploadimage/uploadimage.component';
import { LoginComponent } from './user/login/login.component';
import { RegistrationComponent } from './user/registration/registration.component';
import { UserComponent } from './user/user.component';
import { VisitorPanelComponent } from './visitor-panel/visitor-panel.component';

const routes: Routes = [
  {path:'',redirectTo:'/user/login',pathMatch:'full'},
  {path:'user',component:UserComponent,
  children:[
    {path:'registration',component:RegistrationComponent},
    {path:'login',component:LoginComponent}
  ]
    
  },
  {path:'home',component:HomeComponent,canActivate:[AuthGuard]},
  {path:'visitorpanel',component:VisitorPanelComponent},
  {path:'adminpanel',component:AdminPanelComponent,canActivate:[AuthGuard],data:{permittedRoles:['Owner','CoOwner']}},
  {path:'addnewbook',component:AddbookComponent},
  {path:'updatebook/:BookId',component:UpdatebookComponent},
  {path:'addcomment/:BookId',component:CommentsComponent},
  {path:'uploadbk',component:UploadimageComponent},
  {path:'addcoowner',component:AddcoownerComponent},
  //  {path:'adminpanel',component:AdminPanelComponent,canActivate:[AuthGuard],data:{permittedRoles:['CoOwner']}}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
