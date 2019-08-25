import { Component, OnInit } from '@angular/core';
import { ModuleLink, ItemLink } from '@shared/models/local';

@Component({
  selector: 'lol-left-sidenav',
  templateUrl: './left-sidenav.component.html',
  styleUrls: ['./left-sidenav.component.scss']
})
export class LeftSidenavComponent implements OnInit {
  moduleLinks: ModuleLink[] = [];

  constructor() {
    this.moduleLinks = [
      new ModuleLink('Infostructure', 'link1', [
        new ItemLink('Info 1', '/test'),
        new ItemLink('Info 2', '/test'),
        new ItemLink('Info 3', '/test'),
      ]),
      new ModuleLink('Settings', 'link2', [
        new ItemLink('Settings 1', '/test'),
        new ItemLink('Settings 2', '/test'),
        new ItemLink('Settings 3', '/test'),
      ])
    ];
  }

  ngOnInit() {
  }

}
