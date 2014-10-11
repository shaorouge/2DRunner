
using System;
using UnityEngine;

public class BackwardState : RunState
{
	private float speed;

	public BackwardState (GameObject player,
	                    IStateTransition stateTransition,
	                    Behaviour behaviour,
	                    float speed) : base(player, stateTransition, behaviour)
	{
		this.speed = speed;
	}

	public override void update()
	{
		if(handleInput ())
		{
			return;
		}
		
		if(Player.transform.position.x > PlayerBehaviour.getThreshold("pos_x"))
		{
			Player.rigidbody2D.AddForce(Vector3.left * speed);
		}
		else
		{
			StateTransition.OnStateTransition("run");
		}
	}
}









