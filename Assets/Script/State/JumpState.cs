
using System;
using UnityEngine;
public class JumpState : IState
{
	public StateMachine FSM{ get; private set;}
	public GameObject Player{ get; private set;}
	public Vector3 Force{ get; private set; }

	public JumpState (GameObject player, StateMachine fsm, Vector3 force)
	{
		Player = player;
		FSM = fsm;
		Force = force;
	}

	public void enter()
	{
		Player.rigidbody2D.AddForce (Force);
		Player.GetComponent<Animator> ().SetInteger ("AnimState", 2);
	}

	public void exit()
	{

	}

	public void update()
	{
		if(Player.rigidbody2D.velocity.y > -0.2 && Player.rigidbody2D.velocity.y < 0.2)
		{
			FSM.switchState("top");
		}
	}
}

