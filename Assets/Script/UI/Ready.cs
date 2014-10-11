using UnityEngine;
using System.Collections;

public class Ready : MonoBehaviour 
{

	private float startTime;
	
	private int boxWidth = 400;
	private int boxHeight = 200;
	private int labelWidth = 300;
	private int labelHeight = 180;
	private int posX; 
	private int posY;
	
	void OnGUI()
	{
		posX = Screen.width / 2 - boxWidth;
		posY = Screen.height / 2 - boxHeight;

		if (Time.unscaledTime - startTime >= 3.0f) 
		{
			Time.timeScale =  1.0f;
			Destroy (gameObject);
		}
		else
		{
			GUI.Label (new Rect (posX, posY, boxWidth, boxHeight), "Ready " + (int)(3 - Time.unscaledTime + startTime));
		}
	}

	void Awake()
	{
		Time.timeScale = 0.0f;
	}

	// Use this for initialization
	void Start () 
	{
		startTime = Time.unscaledTime;
	}
}
