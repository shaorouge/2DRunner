
using System;
public class EventManager
{
	public delegate void HandleEvent();
	public static event HandleEvent handleEvent;

	private static EventManager instance;

	private EventManager ()
	{

	}

	public static EventManager getInstance()
	{
		if (instance == null) 
		{
			instance = new EventManager();
		}

		return instance;
	}

	public void OnEvent()
	{
		if (handleEvent != null) 
		{
			handleEvent();
		}
	}
}

