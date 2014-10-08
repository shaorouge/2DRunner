
using System;
using UnityEngine;

public class AdjustState : IState
{
	public StateMachine FSM{ get; private set;}
	public GameObject Player{ get; private set;}

	private float rightPosX; 			//The position the player should be when he's running
	private float speed;

	public AdjustState (GameObject player, StateMachine fsm, float posX, float speed)
	{
		Player = player;
		FSM = fsm;
		rightPosX = posX;
		this.speed = speed;
	}

	public void enter()
	{

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
		else if (Player.transform.position.x > rightPosX) 
		{
			Player.rigidbody2D.AddForce(Vector3.left * speed);
		}
		else if(Player.transform.position.x < rightPosX)
		{
			Player.rigidbody2D.AddForce(Vector3.right * speed);
		}
		else if(Player.transform.position.x == rightPosX)
		{
			Player.rigidbody2D.velocity = Vector2.zero;
			FSM.switchState("run");
		}
	}
}








