import { Component, OnInit } from '@angular/core';
import { HttpClientModule, HttpClient } from '@angular/common/http';   
import { Book } from '../book';  
import { FormBuilder, Validators } from '@angular/forms';
import { BooklistService } from '../booklist.service';
@Component({
  selector: 'app-addbook',
  templateUrl: './addbook.component.html',
  styleUrls: ['./addbook.component.css']
})
export class AddbookComponent implements OnInit {

  dataSaved = false;  
  booksForm: any;  
   allBooks: any;  
  //allBooks: string[] | any;  
  bookIdUpdate = null;  
  massage = null; 
  constructor(private formbulider: FormBuilder, private booklistservice:BooklistService) { }

  ngOnInit(): void {
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
  resetForm() {  
    this.booksForm.reset();   
    this.dataSaved = false;  
  }  
  
}

