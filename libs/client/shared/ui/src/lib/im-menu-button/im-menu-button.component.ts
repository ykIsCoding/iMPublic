
import { ChangeDetectionStrategy, Component, ElementRef,  Input, OnInit } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';
import { StatefulComponent } from '@involvemint/client/shared/util';


export interface ImMenuButtonComponentInput {
  showRedDot: boolean
}


@Component({
  selector: 'im-menu-button',
  templateUrl: './im-menu-button.component.html',
  styleUrls: ['./im-menu-button.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
  animations: [

  ],
})

export class ImMenuButtonComponent implements Required<ImMenuButtonComponentInput>, OnInit {
  
  @Input() showRedDot!: boolean;

  ngOnInit(): void {
      this.showRedDot = true //FIND SOME SHARED STATE THAT we can get data of whether user is new or not
  }

  safeContent!: ReturnType<DomSanitizer['bypassSecurityTrustHtml']>;


  constructor(
    public readonly el: ElementRef,
    private readonly sanitized: DomSanitizer,
    
  ) {}
}
