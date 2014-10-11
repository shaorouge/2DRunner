
using System;
using UnityEngine;

public class GameOverColumn : MonoBehaviour
{
	void Start()
	{
		GUI.enabled = false;
	}

	void OnTriggerStay2D(Collider2D other)
	{
		if (other.tag == "Player") 
		{
			Time.timeScale = 0;
		}
	}

}

