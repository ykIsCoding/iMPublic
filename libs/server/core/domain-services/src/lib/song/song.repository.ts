import { Song } from "@involvemint/shared/domain";
import { Injectable } from "@nestjs/common";
import { InjectRepository } from "@nestjs/typeorm";
import { IOrchaTypeormRepository } from "@orcha/typeorm";
import { Repository } from "typeorm";
import { SongEntity } from "./song.entity";

@Injectable()
export class SongRepository extends IOrchaTypeormRepository<Song> {
    constructor(@InjectRepository(SongEntity) protected readonly repo: Repository<Song>) {
        super(repo);
    }
}
