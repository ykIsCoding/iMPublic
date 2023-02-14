import { Attribute, ChangeDetectionStrategy, Component } from '@angular/core';
import { Validators } from '@angular/forms';
import { FormControl, FormGroup } from '@ngneat/reactive-forms';
import { RouteService } from '@involvemint/client/shared/routes';
import { SongOrchestration } from '@involvemint/client/shared/data-access'
import { StatefulComponent, StatusService } from '@involvemint/client/shared/util';
import { catchError, take, tap } from 'rxjs/operators';
import { SongQuery } from '@involvemint/shared/domain';

@Component({
  selector: 'involvemint-create-song',
  templateUrl: './create-song.component.html',
  styleUrls: ['./create-song.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class CreateSongComponent extends StatefulComponent {

  readonly form = new FormGroup({
    name: new FormControl(
      '',
      Validators.compose([(c) => Validators.required(c)])
    ),
    artist: new FormControl(
      '',
      Validators.compose([(c) => Validators.required(c)])
    ),
    album: new FormControl(
      '',
      Validators.compose([(c) => Validators.required(c)])
    )
  });

  constructor(
    private readonly route: RouteService,
    private readonly songOrcha: SongOrchestration,
    private readonly status: StatusService
  ) { 
    super({});
  }

  async submit() {
    await this.status.showLoader();
    this.songOrcha
      .create(SongQuery, {
        name: this.form.value.name,
        artist: this.form.value.artist,
        album: this.form.value.album
      })
      .pipe(
        take(1),
        tap(async (query) => {
          await this.status.dismissLoader();
          await this.status.presentSuccess();
          await this.status.presentAlert({
            title: 'Succeeded!',
            description: `Inserted: ${query.id} ${query.name} ${query.album} ${query.artist} at ${query.dateCreated}` 
          });
          await this.route.to.login.ROOT();
        }),
        catchError(async (error) => {
          await this.status.dismissLoader();
          await this.status.presentAlert({
            title: 'Error Creating Song:',
            description: error.error.message,
          });
        })
      )
      .subscribe();
  }

  back() {
    return this.route.back(() => this.route.to.login.ROOT({ animation: 'back' }));
  }

}
