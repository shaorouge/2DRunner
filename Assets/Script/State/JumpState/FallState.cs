
using System;
using UnityEngine;

public class FallState : PlayerState
{
	public FallState (GameObject player, IStateTransition stateTransition)
	{
		Player = player;
		StateTransition = stateTransition;
	}

	public override void enter()
	{
		Player.GetComponent<Animator> ().SetInteger ("AnimState", 4);
	}

	public override void update()
	{
		if (Player.rigidbody2D.velocity.y == 0) 
		{
			StateTransition.OnStateTransition("run");
		}
	}
}

