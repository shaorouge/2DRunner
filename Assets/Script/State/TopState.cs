
using System;
using UnityEngine;

public class TopState : IState
{
	public StateMachine FSM{ get; private set;}
	public GameObject Player{ get; private set;}
	
	public TopState (GameObject player, StateMachine fsm)
	{
		Player = player;
		FSM = fsm;
	}

	public void enter()
	{
		Player.GetComponent<Animator> ().SetInteger ("AnimState", 3);
	}

	public void exit()
	{

	}

	public void update()
	{
		if (Player.rigidbody2D.velocity.y <= -0.2) 
		{
			FSM.switchState("fall");		
		}
	}
}

