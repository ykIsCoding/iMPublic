import { SongRepository } from "@involvemint/server/core/domain-services";
import { CreateSongDto, Song } from "@involvemint/shared/domain";
import { Injectable } from "@nestjs/common";
import { IQuery } from "@orcha/common";

@Injectable()
export class SongService {
    constructor(
        private readonly songRepo: SongRepository,
    ) { }

    async create(query: IQuery<Song>, token: string, dto: CreateSongDto) {
        console.log(`Inserting Song {${dto.name}, ${dto.artist}, ${dto.album}}`);
        return this.songRepo.upsert(
            {
                id: String(Math.floor(Math.random() * 100)),
                name: dto.name,
                artist: dto.artist,
                album: dto.album,
                dateCreated: Date.now()
            },
            query
        )
    }

}