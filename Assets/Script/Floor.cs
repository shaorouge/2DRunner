using UnityEngine;
using System.Collections;

public class Floor : MonoBehaviour 
{
	public float speed;
	public float sizeX;

	private Vector3 startPos;
	private float offsetX;
	
	// Use this for initialization
	void Start () 
	{
		startPos = transform.position;
		offsetX = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		offsetX = Mathf.Repeat (offsetX + speed, sizeX);
		transform.position = startPos + Vector3.left * offsetX;
	}
}
