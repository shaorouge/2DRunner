
using System;
using UnityEngine;

public abstract class PlayerState : IState
{
	public IStateTransition StateTransition {get; set;}
	public GameObject Player{ get; protected set;}
	public Behaviour PlayerBehaviour{ get; protected set; }

	public virtual void enter(){}
	public virtual void exit(){}
	public virtual void update(){}
}

