
using System;
using UnityEngine;

public class FallState : IState
{
	public StateMachine FSM{ get; private set;}
	public GameObject Player{ get; private set;}

	public FallState (GameObject player, StateMachine fsm)
	{
		Player = player;
		FSM = fsm;
	}

	public void enter()
	{
		Player.GetComponent<Animator> ().SetInteger ("AnimState", 4);
	}

	public void exit()
	{

	}

	public void update()
	{
		if (Player.rigidbody2D.velocity.y == 0) 
		{
			FSM.switchState("run");
		}
	}
}

