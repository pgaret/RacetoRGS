using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyManager2 : MonoBehaviour {
	
	public int i = 0;
	
	public GameObject enemy1;
	public GameObject enemy2;
	
	public float levelCD;
	float levelTimer;
	
	public GameObject player;
	
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (GameObject.FindGameObjectsWithTag("Enemy2").Length == 0)
		{
			SpawnWave();
		}	
	}
	
	void SpawnWave()
	{
		if (i == 0)
		{
			GameObject enemy = Instantiate(enemy1, GameObject.Find ("A3").transform.position, Quaternion.identity) as GameObject;
			enemy.GetComponent<Enemy>().player = player; enemy.GetComponent<Enemy>().CreatePath("53");enemy.transform.tag = "Enemy2";
			enemy = Instantiate(enemy1, GameObject.Find ("A5").transform.position, Quaternion.identity) as GameObject;
			enemy.GetComponent<Enemy>().player = player; enemy.GetComponent<Enemy>().CreatePath("41");enemy.transform.tag = "Enemy2";
			enemy = Instantiate(enemy1, GameObject.Find ("A5").transform.position, Quaternion.identity) as GameObject;
			enemy.GetComponent<Enemy>().player = player; enemy.GetComponent<Enemy>().CreatePath("41");enemy.transform.tag = "Enemy2";		
		}
		if (i == 1)
		{
			
		}
		i++;
	}
	
}
