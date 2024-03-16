using System;

public class DABRadio : IMedia {
	const float SEEK_STEP = 0.5f;
	const float MAX_FRENQUENCY = 108f;
	const float MIN_FRENQUENCY = 87.5f;
    private bool isPlaying;
	public float frequency { get; private set;}

    public string MessageToDisplay
	{
		get {
            if (isPlaying) {
                return $"{MediaState.Hearing}... FM - {frequency} MHz";
            } else {
                return $"{MediaState.Stopped}... RADIO OFF";
            }
		}
	}

    public DABRadio() {
	}

    public void Play() {
        if (!isPlaying) {
            frequency = MIN_FRENQUENCY; // Frecuencia inicial
            isPlaying = true;
            Console.WriteLine(MessageToDisplay);
        }
    }

    public void Stop() {
        isPlaying = false;
        Console.WriteLine(MessageToDisplay);
    }

    public void Pause() {
        if (isPlaying) {
            isPlaying = false;
            Console.WriteLine($"{MediaState.Paused} - BUFFERING... FM - {frequency} MHz");
        }
    }

    public void Next() {
        if (isPlaying) {
            frequency = (frequency + SEEK_STEP) % MAX_FRENQUENCY; // Si llega al final de la banda, vuelve al principio
            Console.WriteLine(MessageToDisplay);
        }
    }

    public void Previous() {
        if (isPlaying) {
            frequency = (frequency - SEEK_STEP + MAX_FRENQUENCY) % MAX_FRENQUENCY; // Si llega al principio de la banda, vuelve al final
            Console.WriteLine(MessageToDisplay);
        }
    }
}
