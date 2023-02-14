import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CreateSongComponent } from './create-song/create-song.component';
import { IonicModule } from '@ionic/angular';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ImFormsModule } from '@involvemint/client/shared/ui';
import { RouterModule } from '@angular/router';

@NgModule({
  imports: [
    CommonModule,
    IonicModule,
    FormsModule,
    ReactiveFormsModule,
    ImFormsModule,
    RouterModule.forChild([
      {
        path: '',
        component: CreateSongComponent
      }
    ])
  ],
  declarations: [
    CreateSongComponent
  ],
})
export class ClientSongModule {}
