
using System;
using UnityEngine;

public class RunState : PlayerState
{
	protected float rightPosX; 			//The position the player should be when he's running

	public RunState (GameObject player, IStateTransition stateTransition, Behaviour behaviour)
	{
		Player = player;
		StateTransition = stateTransition;
		PlayerBehaviour = behaviour;
	}

	public override void enter()
	{
		Player.GetComponent<Animator> ().SetInteger ("AnimState", 0);
	}

	protected bool handleInput()
	{
		if(Input.GetKey ("up"))
		{
			StateTransition.OnStateTransition("jump");
			return true;
		}
		else if(Input.GetKey ("down"))
		{
			StateTransition.OnStateTransition("slip");
			return true;
		}

		return false;
	}

	public override void update()
	{
		if(handleInput ())
		{
			return;
		}

		if(Player.transform.position.x > PlayerBehaviour.getThreshold("pos_x"))
		{
			StateTransition.OnStateTransition("backward");
		}
		else if(Player.transform.position.x < PlayerBehaviour.getThreshold("pos_x"))
		{
			StateTransition.OnStateTransition("forward");
		}
	}
}

