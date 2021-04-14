import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {ReactiveFormsModule,FormsModule} from "@angular/forms";
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UserComponent } from './user/user.component';
import { RegistrationComponent } from './user/registration/registration.component';
import { UserService } from './shared/user.service';
import {HttpClientModule, HTTP_INTERCEPTORS} from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { ToastrModule } from 'ngx-toastr';
import { LoginComponent } from './user/login/login.component';
import { HomeComponent } from './home/home.component';
import { OwnerComponent } from './owner/owner.component';
import { AdminPanelComponent } from './admin-panel/admin-panel.component';
import { VisitorPanelComponent } from './visitor-panel/visitor-panel.component';
import { AuthInterceptor } from './auth/auth.interceptor';
import { UploadComponent } from './upload/upload.component';
import { BooklistService } from './booklist.service';
import { AddbookComponent } from './addbook/addbook.component';
import { UpdatebookComponent } from './updatebook/updatebook.component';
import { CommentsComponent } from './comments/comments.component';
import { UploadimageComponent } from './uploadimage/uploadimage.component';
import { AddcoownerComponent } from './addcoowner/addcoowner.component';

@NgModule({
  declarations: [
    AppComponent,
    UserComponent,
    RegistrationComponent,
    LoginComponent,
    HomeComponent,
    OwnerComponent,
    AdminPanelComponent,
    VisitorPanelComponent,
    UploadComponent,
    AddbookComponent,
    UpdatebookComponent,
    CommentsComponent,
    UploadimageComponent,
    AddcoownerComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot(),
    FormsModule
  ],
  providers: [UserService,{
    provide:HTTP_INTERCEPTORS,
    useClass:AuthInterceptor,
    multi:true
  },HttpClientModule,BooklistService],
  bootstrap: [AppComponent],
})

export class AppModule { }
