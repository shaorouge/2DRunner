using UnityEngine;
using System.Collections;

public class Column : MonoBehaviour 
{
	public float speed;
	public float borderX;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (transform.position.x < borderX) 
		{
			gameObject.SetActive(false);
		}
		else 
		{
			transform.position = transform.position + Vector3.left * speed;
		}
	}
}
