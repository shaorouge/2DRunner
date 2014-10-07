
using System;
using UnityEngine;

public class SlipState : IState
{
	public StateMachine FSM{ get; private set;}
	public GameObject Player{ get; private set;}

	public Vector2 StandSize{ get; private set;} 			//The bounding box size when the player is running
	public Vector2 StandCenter{ get; private set;}
	public Vector2 SlipSize{ get; private set;}
	public Vector2 SlipCenter{ get; private set;}

	private BoxCollider2D bx;								//The box collider

	public SlipState (GameObject player, StateMachine fsm,
	                  Vector2 standSize, Vector2 standCenter,
	                  Vector2 slipSize, Vector2 slipCenter)
	{
		Player = player;
		FSM = fsm;

		StandSize = standSize;
		StandCenter = standCenter;
		SlipSize = slipSize;
		SlipCenter = slipCenter;

		bx = Player.GetComponent<BoxCollider2D> ();
	}

	public void enter()
	{
		Player.GetComponent<Animator> ().SetInteger ("AnimState", 1);
		bx.center = SlipCenter;
		bx.size = SlipSize;
	}

	public void exit()
	{
		bx.center = StandCenter;
		bx.size = StandSize;
	}

	public void update()
	{
		if (!Input.GetKey ("down")) 
		{
			FSM.switchState("run");
		}
	}
}

