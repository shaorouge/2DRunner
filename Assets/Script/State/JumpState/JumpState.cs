
using System;
using UnityEngine;
public class JumpState : PlayerState
{
	public Vector3 Force{ get; private set; }

	public JumpState (GameObject player, IStateTransition stateTransition, Vector3 force)
	{
		Player = player;
		StateTransition = stateTransition;
		Force = force;
	}

	public override void enter()
	{
		Player.rigidbody2D.AddForce (Force);
		Player.GetComponent<Animator> ().SetInteger ("AnimState", 2);
	}

	public override void update()
	{
		if(Player.rigidbody2D.velocity.y > -0.2 && Player.rigidbody2D.velocity.y < 0.2)
		{
			StateTransition.OnStateTransition("top");
		}
	}
}

