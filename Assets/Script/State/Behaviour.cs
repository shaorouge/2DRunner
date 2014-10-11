
using System.Collections;
using UnityEngine;

public class Behaviour
{
	private Hashtable thresholdTable;

	public Behaviour ()
	{
		thresholdTable = new Hashtable ();
	}

	public void addThreshold(string name, float threshold)
	{
		thresholdTable.Add(name, threshold);
	}

	public float getThreshold(string name)
	{
		return (float)thresholdTable[name];
	}
}

