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
			GameObject enemy = Instantiate(enemy2, GameObject.Find ("A3").transform.position, enemy2.transform.rotation) as GameObject;
			enemy.GetComponent<Enemy>().player = player; enemy.GetComponent<Enemy>().CreatePath("53");enemy.transform.tag = "Enemy2";
			enemy = Instantiate(enemy2, GameObject.Find ("A5").transform.position, enemy2.transform.rotation) as GameObject;
			enemy.GetComponent<Enemy>().player = player; enemy.GetComponent<Enemy>().CreatePath("35");enemy.transform.tag = "Enemy2";
		}
		if (i == 1)
		{
			GameObject enemy = Instantiate(enemy1, GameObject.Find ("A0").transform.position, Quaternion.identity) as GameObject;
			enemy.GetComponent<Enemy>().player = player; enemy.GetComponent<Enemy>().CreatePath("45");enemy.transform.tag = "Enemy2";
			enemy = Instantiate(enemy1, GameObject.Find ("A2").transform.position, Quaternion.identity) as GameObject;
			enemy.GetComponent<Enemy>().player = player; enemy.GetComponent<Enemy>().CreatePath("43");enemy.transform.tag = "Enemy2";
		}
		if (i == 2)
		{
			GameObject enemy = Instantiate(enemy1, GameObject.Find ("A1").transform.position, Quaternion.identity) as GameObject;
			enemy.GetComponent<Enemy>().player = player; enemy.GetComponent<Enemy>().CreatePath("71");enemy.transform.tag = "Enemy2";
			enemy = Instantiate(enemy2, GameObject.Find ("A0").transform.position, enemy2.transform.rotation) as GameObject;
			enemy.GetComponent<Enemy>().player = player; enemy.GetComponent<Enemy>().CreatePath("46");enemy.transform.tag = "Enemy2";
			enemy = Instantiate(enemy2, GameObject.Find ("A2").transform.position, enemy2.transform.rotation) as GameObject;
			enemy.GetComponent<Enemy>().player = player; enemy.GetComponent<Enemy>().CreatePath("48");enemy.transform.tag = "Enemy2";
		}
		if (i == 3)
		{
			GameObject enemy = Instantiate(enemy2, GameObject.Find ("A1").transform.position, enemy2.transform.rotation) as GameObject;
			enemy.GetComponent<Enemy>().player = player; enemy.GetComponent<Enemy>().CreatePath("372");enemy.transform.tag = "Enemy2";
			enemy = Instantiate(enemy2, GameObject.Find ("A1").transform.position, enemy2.transform.rotation) as GameObject;
			enemy.GetComponent<Enemy>().player = player; enemy.GetComponent<Enemy>().CreatePath("570");enemy.transform.tag = "Enemy2";
			enemy = Instantiate(enemy2, GameObject.Find ("A1").transform.position, enemy2.transform.rotation) as GameObject;
			enemy.GetComponent<Enemy>().player = player; enemy.GetComponent<Enemy>().CreatePath("680");enemy.transform.tag = "Enemy2";
			enemy = Instantiate(enemy2, GameObject.Find ("A1").transform.position, enemy2.transform.rotation) as GameObject;
			enemy.GetComponent<Enemy>().player = player; enemy.GetComponent<Enemy>().CreatePath("862");enemy.transform.tag = "Enemy2";
		}
		if (i == 4)
		{
			GameObject enemy = Instantiate(enemy1, GameObject.Find ("A0").transform.position, Quaternion.identity) as GameObject;
			enemy.GetComponent<Enemy>().player = player; enemy.GetComponent<Enemy>().CreatePath("42");enemy.transform.tag = "Enemy2";
			enemy = Instantiate(enemy2, GameObject.Find ("A0").transform.position, enemy2.transform.rotation) as GameObject;
			enemy.GetComponent<Enemy>().player = player; enemy.GetComponent<Enemy>().CreatePath("352");enemy.transform.tag = "Enemy2";
			enemy = Instantiate(enemy2, GameObject.Find ("A2").transform.position, enemy2.transform.rotation) as GameObject;
			enemy.GetComponent<Enemy>().player = player; enemy.GetComponent<Enemy>().CreatePath("530");enemy.transform.tag = "Enemy2";
			enemy = Instantiate(enemy1, GameObject.Find ("A1").transform.position, Quaternion.identity) as GameObject;
			enemy.GetComponent<Enemy>().player = player; enemy.GetComponent<Enemy>().CreatePath("46");enemy.transform.tag = "Enemy2";
			enemy = Instantiate(enemy1, GameObject.Find ("A1").transform.position, Quaternion.identity) as GameObject;
			enemy.GetComponent<Enemy>().player = player; enemy.GetComponent<Enemy>().CreatePath("48");enemy.transform.tag = "Enemy2";
		}
		i++;
	}
	
}
