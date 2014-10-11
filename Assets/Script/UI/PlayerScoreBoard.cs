using UnityEngine;
using System;

public class PlayerScoreBoard : MonoBehaviour
{
	private int score;

	void OnGUI()
	{
		GUI.Label (new Rect (600, 0, 200, 200), "Score: " + score);
	}

	void OnEnable()
	{
		EventManager.handleEvent += new EventManager.HandleEvent (addScore);
	}

	void OnDisable()
	{
		EventManager.handleEvent -= new EventManager.HandleEvent (addScore);
	}

	public void addScore()
	{
		score++;
	}

	public void reset()
	{
		score = 0;
	}

	public int getScore()
	{
		return score;
	}
}

