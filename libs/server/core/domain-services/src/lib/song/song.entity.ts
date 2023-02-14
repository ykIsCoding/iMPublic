import { Song } from "@involvemint/shared/domain";
import { Column, Entity, PrimaryColumn } from "typeorm";
import { DbTableNames } from "../db-table-names";

@Entity({ name: DbTableNames.Song })
export class SongEntity implements Required<Song> {
    @PrimaryColumn('text')
    id!: string;

    @Column()
    name!: string;

    @Column()
    artist!: string;

    @Column()
    album!: string;

    @Column({type: 'bigint'})
    dateCreated!: number;
}