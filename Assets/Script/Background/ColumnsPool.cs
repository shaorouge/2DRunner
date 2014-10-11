using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ColumnsPool : MonoBehaviour 
{
	public int size;			//The size of the object pool
	public float posZ;			//The Z position of each column 
	public float startPosX;		//The start position of each column
	public float playerHeight;
	public float ground;

	public float min;			//The minimum time gap between two columns
	public float max;			//The maximum time gap

	private List<GameObject> pool;

	void Start () 
	{
		ArrayList objList = GameObjectFactory.getInstance ().getGameObjects ();
		GameObject[] objs = new GameObject[objList.Count];
		//IScoreBoard scoreBoard = GameObject.Find ("ScoreBoardText").GetComponent<PlayerScoreBoard>();

		pool = new List<GameObject> ();

		for(int i = 0; i < objList.Count; i++)
		{
			objs[i] = (GameObject)objList[i];
		}

		for (int i = 0; i < size; i++) 
		{
			GameObject gameObj = (GameObject)Instantiate(objs[Random.Range(0, objList.Count)]); 
			//gameObj.GetComponent<Column>().setScoreBoard(scoreBoard);
			gameObj.SetActive(false);
			pool.Add (gameObj);
		}
	}

	void Update()
	{
		if (IsInvoking ("appear")) 
		{
			return;
		}

		Invoke ("appear", Random.Range (min, max));
	}

	void appear()
	{
		int randomInt;

		do 
		{
			randomInt = Random.Range (0, size);
		}
		while(pool[randomInt].activeInHierarchy);

		pool[randomInt].transform.position = getStartPos(pool[randomInt].renderer.bounds.extents.y);
		pool[randomInt].SetActive(true);
		pool[randomInt].GetComponent<Column> ().setPassed (false);
	}

	private Vector3 getStartPos(float extentsY)
	{
		float aboveGround = playerHeight * Random.Range (0, 2);
		float startPosY = aboveGround + ground + extentsY;

		return new Vector3 (startPosX, startPosY, posZ);
	}
}

