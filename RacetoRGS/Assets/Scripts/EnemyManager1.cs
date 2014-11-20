using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyManager1 : MonoBehaviour {

	public int i = 0;
	
	public int playerNumber;
	
	public GameObject enemy1;
	public GameObject enemy2;
	
	public float levelCD;
	float levelTimer;
	
	public GameObject player1;
	public GameObject player2;
	
	GameObject player;

	// Use this for initialization
	void Start ()
	{
		if (playerNumber == 1) player = player1;
		else player = player2;
		
		Debug.Log (player.name);

	}
	
	// Update is called once per frame
	void Update ()
	{
//		Debug.Log (GameObject.FindGameObjectsWithTag("Enemy").Length);
		if (GameObject.FindGameObjectsWithTag("Enemy1").Length == 0 && playerNumber == 1)
		{
			SpawnWave();
		}	
		if (GameObject.FindGameObjectsWithTag("Enemy2").Length == 0 && playerNumber == 2)
		{
			SpawnWave();
		}	
	}
	
	void SpawnWave()
	{
		if (i == 0)
		{
			GameObject enemy = Instantiate(enemy1, GameObject.Find ("B3").transform.position, Quaternion.identity) as GameObject;
			Debug.Log (GameObject.Find ("B3").transform.position+" "+enemy1.transform.position);
			enemy.GetComponent<Enemy>().player = player; enemy.GetComponent<Enemy>().CreatePath("53");
		}
		if (i == 1)
		{
			GameObject enemy = Instantiate(enemy1) as GameObject;
			enemy.GetComponent<Enemy>().player = player; enemy.GetComponent<Enemy>().CreatePath("34543");
		}
		i++;
	}
	
}
