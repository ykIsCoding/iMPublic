import { IsOptional, IsString } from "class-validator";


export abstract class CreateSongDto {
    @IsString()
    name!: string;

    @IsString()
    artist!: string;

    @IsString()
    album!: string;
}

export abstract class ViewSongDto {
    @IsString()
    id!: string;
}

export abstract class UpdateSongDto {
    @IsString()
    id!: string;

    @IsString()
    @IsOptional()
    artist!: string;

    @IsString()
    @IsOptional()
    album!: string;
}

export abstract class DeleteSongDto {
    @IsString()
    id!: string;
}