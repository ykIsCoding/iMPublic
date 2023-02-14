import { SongService } from "@involvemint/server/core/application-services";
import { CreateSongDto, InvolvemintOrchestrations, ISongOrchestration, Song } from "@involvemint/shared/domain";
import { IQuery } from "@orcha/common";
import { IServerOrchestration, ServerOperation, ServerOrchestration } from "@orcha/nestjs";

@ServerOrchestration(InvolvemintOrchestrations.song)
export class SongOrchestration implements IServerOrchestration<ISongOrchestration> {
    constructor(private readonly song: SongService) {}

    @ServerOperation()
    async create(query: IQuery<Song>, token: string, dto: CreateSongDto) {
        return this.song.create(query, token, dto);
    }

}
