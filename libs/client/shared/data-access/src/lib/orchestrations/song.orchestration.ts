import { InvolvemintOrchestrations, ISongOrchestration } from "@involvemint/shared/domain";
import { ClientOperation, ClientOrchestration, IClientOrchestration } from "@orcha/angular";


@ClientOrchestration(InvolvemintOrchestrations.song)
export class SongOrchestration implements IClientOrchestration<ISongOrchestration> {
    @ClientOperation()
    create!: IClientOrchestration<ISongOrchestration>['create'];
}