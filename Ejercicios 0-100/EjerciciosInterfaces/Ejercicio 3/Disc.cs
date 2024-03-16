using System;

public class Disc {
	public string album {get; private set;}
	public string artist {get; private set;}
	public string[] songs {get; private set;}
	public int numTracks {get; }

	public string NombreCancion(int song) 
	{
		return songs[song];
	}
	public Disc(string album, string artist, string[] songs) 
	{
		this.album = album;
		this.artist = artist;
		this.songs = songs;
		this.numTracks = songs.Length;
	}
	public override string ToString() 
	{
		return $"{album} by {artist} ";
	}
}