using System;

public class CDPlayer : IMedia
{
	private Disc disc { get; set; }
	private ushort track { get; set; }
	private bool mediaIn { get; set; }

	public string MessageToDisplay
	{
		get
		{
			if (disc == null)
			{
				return "NO DISC";
			}
			else if (mediaIn)
			{
				return $"{MediaState.Playing}... {disc.ToString()} Track {track + 1} - {disc.songs[track]}";
			}
			else
			{
				return $"{disc.ToString()}";
			}
		}
	}

	public CDPlayer()
	{
	}

	public void InsertMedia(Disc media)
	{
		if (disc == null)
		{
			disc = media;
			track = 0;
			Play();
		}
		else
		{
			throw new InvalidOperationException("Ya había un disco insertado.");
		}
	}
	public bool ExtractMedia()
	{
		try
		{
			disc = null;
			return true;
		}
		catch (System.Exception)
		{
			throw new System.Exception("No había disco previamente insertado.");
		}

	}

	public void Play()
	{
		if (disc != null)
		{
			mediaIn = true;
			Console.WriteLine(MessageToDisplay);
		}
	}

	public void Stop()
	{
		mediaIn = false;
		Console.WriteLine($"{MediaState.Stopped}... {MessageToDisplay}");
	}

	public void Pause()
	{
		if (mediaIn)
		{
			mediaIn = false;
			Console.WriteLine($"{MediaState.Paused}... {MessageToDisplay}");
		}
	}

	public void Next()
	{
		if (mediaIn && disc != null)
		{
			track = (ushort)((ushort)(track + 1) % disc.songs.Length);
			Console.WriteLine(MessageToDisplay);
		}
	}

	public void Previous()
	{
		if (mediaIn && disc != null)
		{
			if(track >= 0){
				track = (ushort)((ushort)(track - 1) % disc.songs.Length);
			} else{
				track = 0;
				track = (ushort)((ushort)(track - 1) % disc.songs.Length);
			}
			Console.WriteLine(MessageToDisplay);
		}
	}
}
