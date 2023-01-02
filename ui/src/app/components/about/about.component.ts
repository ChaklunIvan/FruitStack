import {Component, OnDestroy, OnInit} from '@angular/core';

@Component({
  selector: 'app-about',
  templateUrl: './about.component.html',
  styleUrls: ['./about.component.css']
})
export class AboutComponent implements OnInit, OnDestroy{

  htmlTag: HTMLElement = document.getElementsByTagName('html')[0];

  ngOnInit() {
    this.htmlTag.classList.add('about-page');
  }

  ngOnDestroy() {
    this.htmlTag.classList.remove('about-page')
  }

}
