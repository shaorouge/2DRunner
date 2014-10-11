using UnityEngine;
using System.Collections;

public class TEst : MonoBehaviour
{
	void Start()
	{
		EventManager.handleEvent += new EventManager.HandleEvent (output1);
		EventManager.handleEvent += new EventManager.HandleEvent (output2);

		EventManager.getInstance ().OnEvent ();
	}

	void output1()
	{
		Debug.Log ("output1");
	}

	void output2()
	{
		Debug.Log ("output2");
	}
}
