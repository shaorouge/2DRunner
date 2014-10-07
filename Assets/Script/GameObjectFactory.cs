using UnityEngine;
using System.Collections;
using System.Xml;

public class GameObjectFactory
{
	private static GameObjectFactory _instance;
	private Hashtable objTable;

	private GameObjectFactory()
	{

	}

	public void init(XmlNode root)
	{
		objTable = new Hashtable ();

		try
		{
			if(root.HasChildNodes)
			{
				foreach(XmlNode node in root)
				{
					objTable.Add(node.InnerText, Resources.Load ("Prefabs/" + node.InnerText));
				}
			}
		}
		catch(XmlException e)
		{
			Debug.Log ("Can't read data from xml file!");
			Debug.Log (e.Message);
		}
	}

	public GameObject getGameObject(string key)
	{
		return objTable[key] as GameObject;
	}

	public ArrayList getKeyList()
	{
		return new ArrayList(objTable.Keys);
	}

	public ArrayList getGameObjects()
	{
		return new ArrayList (objTable.Values);
	}

	public static GameObjectFactory getInstance()
	{
		if(_instance == null)
		{
			_instance = new GameObjectFactory();
		}

		return _instance;
	}
}
