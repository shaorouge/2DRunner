
using System;
using UnityEngine;

public class TopState : PlayerState
{
	public TopState (GameObject player, StateMachine fsm)
	{
		Player = player;
		FSM = fsm;
	}

	public override void enter()
	{
		Player.GetComponent<Animator> ().SetInteger ("AnimState", 3);
	}

	public override void update()
	{
		if (Player.rigidbody2D.velocity.y <= -0.2) 
		{
			FSM.switchState("fall");		
		}
	}
}

