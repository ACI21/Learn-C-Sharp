using System;

public class DABRadioCD : IMedia {
	public CDPlayer cDPlayer { get; private set;}
	public DABRadio dABRadio { get; private set;}
	public Disc insertDisc { get; private set;}
	public IMedia activeDevice { get; private set;}
	public Disc InsertDisc {
		set {
			insertDisc = value;
		}
	}

    public string MessageToDisplay => $"MODO: {(activeDevice == cDPlayer ? "CD" : "DAB")}\nSTATE: {activeDevice.MessageToDisplay}\n[1]Play [2]Pause [3]Stop [4]Prev [5]Next [6]Switch [7]Insert CD [8]Extract CD, [ESC]Turn off";

    public DABRadioCD() 
	{
		cDPlayer = new CDPlayer();
        dABRadio = new DABRadio();
		activeDevice = dABRadio;
	}
	public void InsertCD(Disc disc) {
        cDPlayer.InsertMedia(disc);
        activeDevice = cDPlayer;
    }
	public void ExtractCD() 
	{
		if(cDPlayer.ExtractMedia()){
			Console.WriteLine("Disco extraído. \n Cambiando de modo...");
			SwitchMode();
		}else{
			Console.WriteLine("No había disco previamente insertado. \n Cambiando de modo...");
			SwitchMode();
		}
	}
	public void SwitchMode() 
	{
		activeDevice = (activeDevice == cDPlayer) ? (IMedia)dABRadio : (IMedia)cDPlayer;
        Console.WriteLine(MessageToDisplay);
	}

    public void Play() {
        activeDevice.Play();
    }

    public void Stop() {
        activeDevice.Stop();
    }

    public void Pause() {
        activeDevice.Pause();
    }

    public void Next() {
        activeDevice.Next();
    }

    public void Previous() {
        activeDevice.Previous();
    }
}
