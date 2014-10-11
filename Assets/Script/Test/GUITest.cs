
using UnityEngine;
using System;


public class GUITest : MonoBehaviour
{
	public Texture2D titleImage;

	void OnGUI () 
	{
		// Make a background box
		GUI.Box(new Rect(10,10,800,450), "");

		GUI.Label (new Rect (150, 30, 400, 400), titleImage);
		GUI.Label (new Rect (550, 100, 600, 300), "Dummy Runner");

		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(320,270,200,100), "Start")) 
		{
			Application.LoadLevel("Game");
		}
		

	}
}

