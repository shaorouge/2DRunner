using UnityEngine;
using System.Collections;

public class TEst : MonoBehaviour
{
	private RaycastHit2D hitInfo;
	private Vector2 pos2D = Vector2.zero;

	void Update()
	{
		pos2D.x = transform.position.x;
		pos2D.y = transform.position.y - GetComponent<BoxCollider2D>().bounds.extents.y - 0.1f;

		Debug.Log (GetComponent<BoxCollider2D>().bounds.extents.y);

		hitInfo = Physics2D.Raycast(pos2D, - Vector2.up);

		if(hitInfo != null)
		{
			Debug.DrawLine(pos2D, hitInfo.point);
			Debug.Log (hitInfo.collider.tag);
		}
	}

	public void Output()
	{
		Debug.Log ("output");
	}
}
