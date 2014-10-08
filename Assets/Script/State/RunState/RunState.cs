
using System;
using UnityEngine;

public class RunState : PlayerState
{
	protected float rightPosX; 			//The position the player should be when he's running

	public RunState (GameObject player, StateMachine fsm, Behaviour behaviour)
	{
		Player = player;
		FSM = fsm;
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
			FSM.switchState("jump");
			return true;
		}
		else if(Input.GetKey ("down"))
		{
			FSM.switchState("slip");
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
			FSM.switchState("backward");
		}
		else if(Player.transform.position.x < PlayerBehaviour.getThreshold("pos_x"))
		{
			FSM.switchState("forward");
		}
	}
}

