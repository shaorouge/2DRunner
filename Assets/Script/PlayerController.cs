﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public StateMachine FSM{ get; set;}

	// Use this for initialization
	void Start () 
	{
		FSM.CurrentState = (IState)FSM.StateTable["run"];
	}
	
	// Update is called once per frame
	void Update () 
	{
		FSM.CurrentState.update ();
	}
}