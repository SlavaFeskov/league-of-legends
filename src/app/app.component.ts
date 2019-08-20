import { Component } from '@angular/core';
import { camelCase } from 'lodash';

@Component({
  selector: 'lol-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = camelCase('league-of-legends');
}
