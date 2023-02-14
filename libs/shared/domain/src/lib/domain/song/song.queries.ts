import { createQuery } from "@orcha/common";
import { Song } from "./song.model";

export const SongQuery = createQuery<Song>()({
    id: true,
    name: true,
    artist: true,
    album: true,
    dateCreated: true,
})