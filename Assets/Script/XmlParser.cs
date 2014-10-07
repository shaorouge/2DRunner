using UnityEngine;
using System.IO;
using System.Collections;
using System.Xml;

public class XmlParser
{
	private static XmlParser _instance;

	private XmlParser()
	{
	}

	public XmlNode parse(string data)
	{
		XmlDocument xmlDoc = new XmlDocument ();
		xmlDoc.Load (data);

		return xmlDoc.FirstChild;
	}

	public static XmlParser getInstance()
	{
		if (_instance == null) 
		{
			_instance = new XmlParser();
		}

		return _instance;
	}
}
















