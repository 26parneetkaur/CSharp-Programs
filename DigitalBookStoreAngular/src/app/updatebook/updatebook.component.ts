import { Component, OnInit } from '@angular/core';
import { HttpClientModule, HttpClient } from '@angular/common/http';   
import { Book } from '../book';  
import { FormBuilder, FormControl, Validators } from '@angular/forms';
import { BooklistService } from '../booklist.service';
import {ActivatedRoute} from '@angular/router';

@Component({
  selector: 'app-updatebook',
  templateUrl: './updatebook.component.html',
  styleUrls: ['./updatebook.component.css']
})
export class UpdatebookComponent implements OnInit {
  dataSaved = false;  
  BookId:number|any;
  booksForm: any;  
   allBooks: any;  
  //allBooks: string[] | any;  
  bookIdUpdate = null;  
  massage = null; 
  constructor(private formbulider: FormBuilder, private booklistservice:BooklistService,private router:ActivatedRoute) { }

  ngOnInit(): void {
    this.booksForm = this.formbulider.group({  
      BookName: ['', [Validators.required]],  
      AuthorName: ['', [Validators.required]],  
      BookDescription: ['', [Validators.required]],  
      Price: ['', [Validators.required]],  
      PublicationYear: ['', [Validators.required]],  
      
    });  
    this.loadAllBooks();  

    console.log(this.router.snapshot.params.BookId);
    this.BookId=this.router.snapshot.params.BookId;
    this.booklistservice.getBookById(this.BookId).subscribe(book=> {   
      this.dataSaved = false;  
      this.bookIdUpdate = book.BookId;  
      this.booksForm.controls['BookName'].setValue(book.BookName);  
     this.booksForm.controls['AuthorName'].setValue(book.AuthorName);  
      this.booksForm.controls['BookDescription'].setValue(book.BookDescription);  
      this.booksForm.controls['Price'].setValue(book.Price);  
      this.booksForm.controls['PublicationYear'].setValue(book.PublicationYear);  
       
    });  
    // this.booklistservice.getUpdateBook(this.router.snapshot.params.BookId).subscribe((res:any)=>{
    //   this.booksForm = this.formbulider.group({  
    //     BookName: new FormControl(res['BookName']),  
    //     AuthorName: new FormControl(res['AuthorName']),  
    //     BookDescription: new FormControl(res['BookDescription']),  
    //     Price: new FormControl(res['Price']),  
    //     PublicationYear: new FormControl(res['PublicationYear']),  
        
    //   })
    //   console.log(res);
    // })
  }
  loadAllBooks() {  
    this.booklistservice.getBookList().subscribe(  
     res=>{
       this.allBooks=res;
       console.log(this.allBooks);
     }
       
      
   );  
   
 } 
  onFormSubmit() {  
    this.dataSaved = false;  
    const booksss = this.booksForm.value;  
    this.CreateBook(booksss);  
    this.booksForm.reset(); 
     
  }

  
    // this.booklistservice.getBookById(BookId).subscribe(book=> {   
    //   this.dataSaved = false;  
    //   this.bookIdUpdate = book.BookId;  
    //   this.booksForm.controls['BookName'].setValue(book.BookName);  
    //  this.booksForm.controls['AuthorName'].setValue(book.AuthorName);  
    //   this.booksForm.controls['BookDescription'].setValue(book.BookDescription);  
    //   this.booksForm.controls['Price'].setValue(book.Price);  
    //   this.booksForm.controls['PublicationYear'].setValue(book.PublicationYear);  
       
    // });  
  
   
  
  CreateBook(book: Book) {  
    if (this.bookIdUpdate == null) {  
      this.booklistservice.createBook(book).subscribe(  
        () => {  
          this.dataSaved = true;  
          this.loadAllBooks();  
          this.bookIdUpdate = null;  
          this.booksForm.reset();  
        }  
      );  
    } else {  
      book.BookId = this.bookIdUpdate;  
      this.booklistservice.updateBook(book).subscribe(() => {  
        this.dataSaved = true;  
        
        this.loadAllBooks();  
        this.bookIdUpdate = null;  
        this.booksForm.reset();  
      });  
    }  
  }  
}
