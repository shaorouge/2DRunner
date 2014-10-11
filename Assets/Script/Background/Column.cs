using UnityEngine;
using System.Collections;

public class Column : MonoBehaviour 
{
	public float speed;
	public float borderX;

	private RaycastHit2D hitInfo;
	private Vector2 rayOriginPos2DUp = Vector2.zero;
	private Vector2 rayOriginPos2DDown = Vector2.zero;
	private bool passed;					//Indicate that the player has passed this column

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
			transform.position += Vector3.left * speed * Time.deltaTime;

			if(passed)
			{
				return;
			}

			rayOriginPos2DUp.x = transform.position.x;
			rayOriginPos2DUp.y = transform.position.y + GetComponent<BoxCollider2D> ().bounds.extents.y + 0.01f;
			rayOriginPos2DDown.x = transform.position.x;
			rayOriginPos2DDown.y = transform.position.y - GetComponent<BoxCollider2D> ().bounds.extents.y - 0.01f;

			rayCasting(rayOriginPos2DUp, Vector2.up);
			rayCasting(rayOriginPos2DDown, - Vector2.up);
		}
	}

	private void rayCasting(Vector2 origin, Vector2 direction)
	{
		hitInfo = Physics2D.Raycast (origin, direction);

		if (hitInfo && hitInfo.collider.tag == "Player") 
		{
			EventManager.getInstance().OnEvent();
			passed = true;
		}
	}

	public void setPassed(bool passed)
	{
		this.passed = passed;
	}
}
