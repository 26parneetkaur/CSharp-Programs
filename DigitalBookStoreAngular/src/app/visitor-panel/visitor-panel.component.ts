import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { BooklistService } from '../booklist.service';

@Component({
  selector: 'app-visitor-panel',
  templateUrl: './visitor-panel.component.html',
  styleUrls: ['./visitor-panel.component.css']
})
export class VisitorPanelComponent implements OnInit {
  booksForm:any;
  allBooks: any;  
  indBook:any;
  bookIdUpdate: null;
  dataSaved: boolean |any;
  constructor(private formbulider: FormBuilder,private booklistservice:BooklistService) { }

  ngOnInit(): void {
    this.booksForm = this.formbulider.group({  
      Comments: ['', [Validators.required]] 
        
      
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
getBook(BookId:number){
  this.booklistservice.getBookById(BookId).subscribe(
    res=>{
      this.indBook=res;
      console.log(this.indBook);
    } 
  );
}
}
