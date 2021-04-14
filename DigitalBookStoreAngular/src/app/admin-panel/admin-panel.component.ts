import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';  
import { Observable } from 'rxjs';  
import { BooklistService } from '../booklist.service'; 
import { HttpClientModule, HttpClient } from '@angular/common/http';   
import { Book } from '../book';  
import { Router } from '@angular/router';
@Component({
  selector: 'app-admin-panel',
  templateUrl: './admin-panel.component.html',
  styleUrls: ['./admin-panel.component.css']
})
export class AdminPanelComponent implements OnInit {

  dataSaved = false;  
  booksForm: any;  
   allBooks: any;  
  //allBooks: string[] | any;  
  bookIdUpdate = null;  
  massage = null;  
  constructor(private formbulider: FormBuilder, private booklistservice:BooklistService,private httpService: HttpClient,private router:Router) { }

  ngOnInit(): void {

    // this.httpService.get('https://localhost:44306/api/BookStore').subscribe(  
    //   data => {  
    //    this.allBooks = data as string [];  
    //   }  
    // ); 
    this.booksForm = this.formbulider.group({  
      BookName: ['', [Validators.required]],  
      AuthorName: ['', [Validators.required]],  
      BookDescription: ['', [Validators.required]],  
      Price: ['', [Validators.required]],  
      PublicationYear: ['', [Validators.required]],  
      
    });  
    this.loadAllBooks();  
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

  loadBookToEdit(BookId: number) {  
    this.booklistservice.getBookById(BookId).subscribe(book=> {   
      this.dataSaved = false;  
      this.bookIdUpdate = book.BookId;  
      this.booksForm.controls['BookName'].setValue(book.BookName);  
     this.booksForm.controls['AuthorName'].setValue(book.AuthorName);  
      this.booksForm.controls['BookDescription'].setValue(book.BookDescription);  
      this.booksForm.controls['Price'].setValue(book.Price);  
      this.booksForm.controls['PublicationYear'].setValue(book.PublicationYear);  
       
    });  
  
  } 
  
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
  
  
  
  deleteBook(BookId: number) {  
    if (confirm("Are you sure you want to delete this ?")) {   
    this.booklistservice.deleteBookById(BookId).subscribe(() => {  
      this.dataSaved = true;  
      this.loadAllBooks();  
      this.bookIdUpdate = null;  
      this.booksForm.reset();  
  
    });  
  }  
  
}  
resetForm() {  
  this.booksForm.reset();   
  this.dataSaved = false;  
}  
onLogOut()
{
  localStorage.removeItem('token');
  this.router.navigate(['/user/login']);
}

}
