
using System;
using System.Collections;

public class StateMachine
{
	public IState CurrentState{ get; set;}
	public Hashtable StateTable{ get; private set;}

	public StateMachine ()
	{
		StateTable = new Hashtable ();
	}

	public void addState(string name, IState state)
	{
		StateTable.Add(name, state);
	}

	public void switchState(string name)
	{
		if (!StateTable.ContainsKey (name)) 
		{
			return;
		}

		CurrentState.exit ();
		CurrentState = (IState)StateTable [name];
		CurrentState.enter ();
	}

	public void update()
	{
		CurrentState.update ();
	}
}


