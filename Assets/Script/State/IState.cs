
using System;

public interface IState
{
	IStateTransition StateTransition {get; set;}

	void enter ();
	void exit ();
	void update ();
}

