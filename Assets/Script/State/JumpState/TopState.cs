
using System;
using UnityEngine;

public class TopState : PlayerState
{
	public TopState (GameObject player, IStateTransition stateTransition)
	{
		Player = player;
		StateTransition = stateTransition;
	}

	public override void enter()
	{
		Player.GetComponent<Animator> ().SetInteger ("AnimState", 3);
	}

	public override void update()
	{
		if (Player.rigidbody2D.velocity.y <= -0.2) 
		{
			StateTransition.OnStateTransition("fall");		
		}
	}
}

