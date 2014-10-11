using UnityEngine;
using System;
using UnityEngine.UI;

public class PlayerScoreBoard : MonoBehaviour, IScoreBoard
{
	public Text text;
	private int score;

	void Update()
	{
		text.text = "Score: " + score;
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

