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
	
	public GameObject player;

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
//		Debug.Log (GameObject.FindGameObjectsWithTag("Enemy").Length);
		if (GameObject.FindGameObjectsWithTag("Enemy1").Length == 0 && playerNumber == 1)
		{
			SpawnWave();
		}
	}
	
	void SpawnWave()
	{
		if (i == 0)
		{
			GameObject enemy = Instantiate(enemy2, GameObject.Find ("B3").transform.position, Quaternion.identity) as GameObject;
			enemy.GetComponent<Enemy>().player = player; enemy.GetComponent<Enemy>().CreatePath("53");enemy.transform.tag = "Enemy1";
			enemy = Instantiate(enemy2, GameObject.Find ("B5").transform.position, Quaternion.identity) as GameObject;
			enemy.GetComponent<Enemy>().player = player; enemy.GetComponent<Enemy>().CreatePath("35");enemy.transform.tag = "Enemy1";	
		}
		if (i == 1)
		{
			GameObject enemy = Instantiate(enemy2, GameObject.Find ("B3").transform.position, Quaternion.identity) as GameObject;
			enemy.GetComponent<Enemy>().player = player; enemy.GetComponent<Enemy>().CreatePath("53");enemy.transform.tag = "Enemy1";
			enemy = Instantiate(enemy2, GameObject.Find ("B5").transform.position, Quaternion.identity) as GameObject;
			enemy.GetComponent<Enemy>().player = player; enemy.GetComponent<Enemy>().CreatePath("35");enemy.transform.tag = "Enemy1";	
			enemy = Instantiate(enemy1, GameObject.Find ("B0").transform.position, Quaternion.identity) as GameObject;
			enemy.GetComponent<Enemy>().player = player; enemy.GetComponent<Enemy>().CreatePath("42");enemy.transform.tag = "Enemy1";
		}
		if (i == 2)
		{
			GameObject enemy = Instantiate(enemy2, GameObject.Find ("B0").transform.position, Quaternion.identity) as GameObject;
			enemy.GetComponent<Enemy>().player = player; enemy.GetComponent<Enemy>().CreatePath("82");enemy.transform.tag = "Enemy1";
			enemy = Instantiate(enemy2, GameObject.Find ("B2").transform.position, Quaternion.identity) as GameObject;
			enemy.GetComponent<Enemy>().player = player; enemy.GetComponent<Enemy>().CreatePath("60");enemy.transform.tag = "Enemy1";
			enemy = Instantiate(enemy1, GameObject.Find ("B1").transform.position, Quaternion.identity) as GameObject;
			enemy.GetComponent<Enemy>().player = player; enemy.GetComponent<Enemy>().CreatePath("71");enemy.transform.tag = "Enemy1";
		}
		i++;
	}
	
}
