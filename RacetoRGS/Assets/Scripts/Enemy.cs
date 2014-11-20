using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Enemy : MonoBehaviour {

	//What are we firing
	public Transform enemyBullet;
	//Where did we come from
	public GameObject player;
	//How many shots per unit time do we fire	
	public float firingRate;
	float timer;
	//Speed
	public float speed;
	//What path are we taking
	private List<Vector3> spots = new List<Vector3>();
	private List<double> path = new List<double>();
	private int currentPos = 0;

	// Use this for initialization
	void Start ()
	{
		timer = Time.time;
	}
	
	
	// Update is called once per frame
	void Update ()
	{
		spots.Clear();
		if (player != null && spots.Count == 0)
		{
			if (player.name == "PlayerRed")
			{
				spots.Add(GameObject.Find ("A0").transform.position); spots.Add(GameObject.Find ("A1").transform.position);spots.Add(GameObject.Find ("A2").transform.position);
				spots.Add(GameObject.Find ("A3").transform.position); spots.Add(GameObject.Find ("A4").transform.position);spots.Add(GameObject.Find ("A5").transform.position);
				spots.Add(GameObject.Find ("A6").transform.position); spots.Add(GameObject.Find ("A7").transform.position);spots.Add(GameObject.Find ("A8").transform.position);
			}
			else
			{
				spots.Add(GameObject.Find ("B0").transform.position); spots.Add(GameObject.Find ("B1").transform.position);spots.Add(GameObject.Find ("B2").transform.position);
				spots.Add(GameObject.Find ("B3").transform.position); spots.Add(GameObject.Find ("B4").transform.position);spots.Add(GameObject.Find ("B5").transform.position);
				spots.Add(GameObject.Find ("B6").transform.position); spots.Add(GameObject.Find ("B7").transform.position);spots.Add(GameObject.Find ("B8").transform.position);
			}
		}
		Vector3 goal = spots[(int)path[currentPos]];
		if (Time.time > timer)
		{
			Vector3 bulletPosition = new Vector3(transform.position.x, transform.position.y - transform.renderer.bounds.extents.y);
			Instantiate (enemyBullet, bulletPosition, Quaternion.identity);
			timer = Time.time + firingRate;
		}
		
		transform.position = Vector3.MoveTowards(transform.position, goal, Time.deltaTime*speed);
		if (transform.position == goal) currentPos += 1;
		if (currentPos == path.Count) Destroy(gameObject);
		
	}
	
	public void CreatePath(string thePath)
	{
		for (int i = 0; i < thePath.Length; i++)
		{
			path.Add (char.GetNumericValue(thePath[i]));
			Debug.Log (path[i]);
		}
	}
}
