import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import {HttpHeaders} from '@angular/common/http';
import {Book} from './book';
import { ActivatedRoute } from '@angular/router';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class BooklistService{
  url="https://localhost:44306/api/BookStore";

  constructor(private http:HttpClient){}

  getBookList(): Observable<Book[]> {
    return this.http.get<Book[]>('https://localhost:44306/api/BookStore/GetBook');
  }

  // getBookById(BookId:number):Observable<Book> {
  //   return this.http.get<Book>(this.url+'/IndBook/'+BookId).pipe(map((res: any)=>{
  //     return res.json()
  //   }))

  // }
  getBookById(BookId:number):Observable<Book> {
    return this.http.get<Book>(this.url+'/IndBook?BookId='+BookId);

  }

//   createBook(book: Book): Observable<Book> {
//     const httpOptions:any={headers:new HttpHeaders({'Content-Type':'application/json'}
//   return this.http.post<Book>(this.url+'/AddBook/',
//   book,httpOptions);
//   }
    
// }
createBook(book: Book): Observable<Book> {  
  const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json'}) };  
  return this.http.post<Book>(this.url + '/AddBook/',  
  book, httpOptions);  
} 

updateBook(book: Book): Observable<Book> {  
  const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json'}) };  
  return this.http.put<Book>(this.url + '/UpdateBook/',  
  book, httpOptions);  
}
// updateBook(BookId:number){
//   const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json'}) };  
//   return this.http.put(this.url + '/UpdateBook?id=' +BookId,httpOptions);
// }
// getUpdateBook(BookId:number){
//    var myurl="https://localhost:44306/api/BookStore/IndBook";
//   //  return this.http.get('$(myurl)/$(BookId)');
//   return this.http.get(this.url+'/GetBook/'+BookId);
// }

deleteBookById(BookId: number): Observable<number> {  
  const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json'}) };  
  return this.http.delete<number>(this.url + '/DeleteBook?id=' +BookId,  
httpOptions);  
} 

}