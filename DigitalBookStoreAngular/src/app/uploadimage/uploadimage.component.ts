import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-uploadimage',
  templateUrl: './uploadimage.component.html',
  styleUrls: ['./uploadimage.component.css']
})

export class UploadimageComponent implements OnInit {

  imageUrl: string ="/assets/img/default.jpg";
  fileToUpload: File |any;
   

  constructor() { }

  ngOnInit(): void {
    
    
  }
  
  handleFileInput(file: FileList) {
    
    
    this.fileToUpload = file.item(0);

    //Show image preview
    var reader = new FileReader();
    reader.onload = (event:any) => {
      this.imageUrl = event.target.result;
    }
    reader.readAsDataURL(this.fileToUpload);
  }
}
