import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { IonicModule } from '@ionic/angular';
import { ImMenuButtonComponent, ImMenuButtonComponentInput} from './im-menu-button.component';

@NgModule({
  declarations: [ImMenuButtonComponent],
  imports: [CommonModule, IonicModule],
  exports: [ImMenuButtonComponent],
})
export class ImMenuButtonModule {
    
}
export {ImMenuButtonComponent, ImMenuButtonComponentInput };
