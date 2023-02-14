
import { IOperation } from "@orcha/common";
import {
    CreateSongDto,
} from "./song.dtos";
import { Song } from "./song.model";

export interface ISongOrchestration {
    create: IOperation<Song, CreateSongDto>;
}
