
using System;
using UnityEngine;

public class FallState : PlayerState
{
	public FallState (GameObject player, StateMachine fsm)
	{
		Player = player;
		FSM = fsm;
	}

	public override void enter()
	{
		Player.GetComponent<Animator> ().SetInteger ("AnimState", 4);
	}

	public override void update()
	{
		if (Player.rigidbody2D.velocity.y == 0) 
		{
			FSM.switchState("run");
		}
	}
}

