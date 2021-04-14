import { Component, OnInit } from '@angular/core';
import { HttpClientModule, HttpClient } from '@angular/common/http';   
import { Book } from '../book';  
import { FormBuilder, Validators } from '@angular/forms';
import { BooklistService } from '../booklist.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-comments',
  templateUrl: './comments.component.html',
  styleUrls: ['./comments.component.css']
})
export class CommentsComponent implements OnInit {
  comment="";
  Bookid:any;
  postComment=[];
  dataSaved = false;  
  booksForm: any;  
   allBooks: any;  
  bookIdUpdate = null;  
  commentForm:any;
  // post()
  // {
  //   this.postComment.push(this.comment);
  //   this.comment="";
  // }
  constructor(private formbulider: FormBuilder, private booklistservice:BooklistService,private route:ActivatedRoute) { }

  ngOnInit(): void {
    this.Bookid=this.route.snapshot.params['BookId'];
    this.getSingleBook();
  }
  getSingleBook()
  {
    this.booklistservice.getBookById(this.Bookid).subscribe(res=>{
        console.log(res);
    })
  }
  
}
