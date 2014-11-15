using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyManager1 : MonoBehaviour {

	public int i = 0;
	
	public int playerNumber;
	public int waves;
	
	public GameObject enemy1;
	public GameObject enemy2;
	
	int[] enemy1Waves;
	int[] enemy2Waves;
	
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
		
		enemy1Waves = new int[waves];
		enemy2Waves = new int[waves];
		//Wave 1
		enemy1Waves[0] = 1;
		enemy2Waves[0] = 2;
		//Wave 2
		enemy1Waves[1] = 3;
		enemy2Waves[1] = 4;
		SpawnEnemies();
		

	}
	
	// Update is called once per frame
	void Update ()
	{
		Debug.Log (GameObject.FindGameObjectsWithTag("Enemy").Length);
		if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
		{
			i++;
			SpawnEnemies();
		}	
	}
	
	void SpawnEnemies()
	{
		for (int j = 0; j < enemy1Waves[i]; j++)
		{
			GameObject enemy = Instantiate(enemy1) as GameObject;
			enemy.GetComponent<Enemy>().OnCreation(player);
		}
		for (int j = 0; j < enemy2Waves[i]; j++)
		{
			GameObject enemy = Instantiate(enemy2) as GameObject;
			enemy.GetComponent<Enemy>().OnCreation(player);
		}
	}
}
