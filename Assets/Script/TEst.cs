using UnityEngine;
using System.Collections;

public class TEst : MonoBehaviour 
{
	public Vector3 startSize;
	public Vector3 changedSize;
	public Vector3 startCenter;
	public Vector3 changedCenter;

	private BoxCollider2D bx;
	// Use this for initialization
	void Start () 
	{
		bx = GetComponent<BoxCollider2D> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey ("left")) 
		{
			rigidbody2D.velocity = Vector3.left;
		} 
		else if (Input.GetKey ("right")) 
		{
			rigidbody2D.velocity = Vector3.right;
		} 
		else if (Input.GetKey ("up")) 
		{
			bx.center = startCenter;
			bx.size = startSize;
		} 
		else if (Input.GetKey ("down")) 
		{
			bx.center = changedCenter;
			bx.size = changedSize;
		}
		else
		{
			rigidbody2D.velocity = Vector3.zero;
		}
	}
}
