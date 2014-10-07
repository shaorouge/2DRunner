
using System;
using UnityEngine;

public class RunState : IState
{
	public StateMachine FSM{ get; private set;}
	public GameObject Player{ get; private set;}

	public RunState (GameObject player, StateMachine fsm)
	{
		Player = player;
		FSM = fsm;
	}

	public void enter()
	{
		Player.GetComponent<Animator> ().SetInteger ("AnimState", 0);
	}

	public void exit()
	{

	}

	public void update()
	{
		if(Input.GetKey ("up"))
		{
			FSM.switchState("jump");
		}
		else if(Input.GetKey ("down"))
		{
			FSM.switchState("slip");
		}
	}
}

