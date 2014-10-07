
using UnityEngine;
using System.Collections;
using System.Xml;

public class Initialization : MonoBehaviour 
{
	// Use this for initialization
	void Awake () 
	{
		TextAsset xmlData;
		
		xmlData = Resources.Load ("XmlData/column") as TextAsset;
		string path = Application.dataPath + "/Resources/XmlData/" + xmlData.name + ".xml";
		
		GameObjectFactory.getInstance().init(XmlParser.getInstance ().parse (path));

		StateMachine fsm = new StateMachine ();
		GameObject obj = GameObject.Find("Player");
		
		fsm.StateTable.Add ("run", new RunState (obj, fsm));
		fsm.StateTable.Add ("slip", new SlipState (obj, fsm, 
		                                           new Vector2(0.6f, 0.8f), new Vector2(0.1f, -0.22f), 
		                                           new Vector2(0.6f, 0.4f), new Vector2(0.1f, -0.44f)));
		fsm.StateTable.Add ("jump", new JumpState (obj, fsm, new Vector3(0.0f, 270f, 0.0f)));
		fsm.StateTable.Add ("top", new TopState (obj, fsm));
		fsm.StateTable.Add ("fall", new FallState (obj, fsm));

		obj.GetComponent<PlayerController>().FSM = fsm; 
	}
}
