
using System;
using UnityEngine;

public class MoveForward : RunState
{
	private float speed;

	public MoveForward (GameObject player, 
	                    StateMachine fsm, 
	                    Behaviour behaviour,
	                    float speed) : base(player, fsm, behaviour)
	{
		this.speed = speed;
	}

	public override void update()
	{
		if(handleInput ())
		{
			return;
		}
		
		if(Player.transform.position.x < PlayerBehaviour.getThreshold("pos_x"))
		{
			Player.rigidbody2D.AddForce(Vector3.right * speed);
		}
		else
		{
			FSM.switchState("run");
		}
	}
}

