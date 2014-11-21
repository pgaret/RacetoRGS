using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Main : MonoBehaviour {

	//Xamera over blue ship
	public Camera camB;
	//Xamera over red ship
	public Camera camR;
	//players
	public Transform player1;
	public Transform player2;
	//List of toMove
	List<GameObject> toMove = new List<GameObject>();
	//Sound Object
	GameObject sound;
	// Use this for initialization
	void Start ()
	{
		sound = GameObject.Find ("Sound");
//		sound.GetComponent<SoundManager>().PlaySound("StarFall");
//		sound.GetComponent<SoundManager>().LoopSound("StarFall");
		toMove.Add(GameObject.Find ("A0")); toMove.Add(GameObject.Find ("A1"));toMove.Add(GameObject.Find ("A2"));
		toMove.Add(GameObject.Find ("A3")); toMove.Add(GameObject.Find ("A4"));toMove.Add(GameObject.Find ("A5"));
		toMove.Add(GameObject.Find ("A6")); toMove.Add(GameObject.Find ("A7"));toMove.Add(GameObject.Find ("A8"));
		toMove.Add(GameObject.Find ("B0")); toMove.Add(GameObject.Find ("B1"));toMove.Add(GameObject.Find ("B2"));
		toMove.Add(GameObject.Find ("B3")); toMove.Add(GameObject.Find ("B4"));toMove.Add(GameObject.Find ("B5"));
		toMove.Add(GameObject.Find ("B6")); toMove.Add(GameObject.Find ("B7"));toMove.Add(GameObject.Find ("B8"));
		toMove.Add(GameObject.Find ("Top2")); toMove.Add(GameObject.Find ("Down2"));toMove.Add(GameObject.Find ("Left2"));
		toMove.Add(GameObject.Find ("Right2")); toMove.Add(GameObject.Find ("Top1"));toMove.Add(GameObject.Find ("Left1"));
		toMove.Add(GameObject.Find ("Right1")); toMove.Add(GameObject.Find ("Down1"));
		toMove.Add(camR.gameObject); toMove.Add (camB.gameObject);
	}
	
	void OnGUI()
	{
		GUI.Box (new Rect(0, Screen.height * 7 / 8, Screen.width, Screen.height / 8), "");
		GUI.Label(new Rect(Screen.width * .1f / 8, Screen.height * 7.25f / 8, Screen.width / 4, Screen.height / 8), "Attack: "+player1.GetComponent<Movement>().attackRate+"\nSpeed");
		GUI.Label(new Rect(Screen.width * 1.1f / 8, Screen.height * 7.25f / 8, Screen.width / 4, Screen.height / 8), "Health: "+player1.GetComponent<Movement>().shipHealth);
		GUI.Label(new Rect(Screen.width * 2.1f / 8, Screen.height * 7.25f / 8, Screen.width / 4, Screen.height / 8), "Lives: "+player1.GetComponent<Movement>().lives);
		GUI.Label(new Rect(Screen.width * 3.1f / 8, Screen.height * 7.25f / 8, Screen.width / 4, Screen.height / 8), "Score: "+player1.GetComponent<Movement>().score);
		GUI.Label(new Rect(Screen.width * 4.1f / 8, Screen.height * 7.25f / 8, Screen.width / 4, Screen.height / 8), "Attack: "+player2.GetComponent<Movement>().attackRate+"\nSpeed");
		GUI.Label(new Rect(Screen.width * 5.1f / 8, Screen.height * 7.25f / 8, Screen.width / 4, Screen.height / 8), "Health: "+player2.GetComponent<Movement>().shipHealth);
		GUI.Label(new Rect(Screen.width * 6.1f / 8, Screen.height * 7.25f / 8, Screen.width / 4, Screen.height / 8), "Lives: "+player2.GetComponent<Movement>().lives);
		GUI.Label(new Rect(Screen.width * 7.1f / 8, Screen.height * 7.25f / 8, Screen.width / 4, Screen.height / 8), "Score: "+player2.GetComponent<Movement>().score);
		
	}
	
	// Update is called once per frame
	void Update ()
	{	
		transform.Translate (Vector3.up*Time.deltaTime);
		
		for (int i = 0; i < toMove.Count; i++) toMove[i].transform.Translate (Vector2.up*Time.deltaTime);
		
		if (gameObject.GetComponent<EnemyManager1>().i >= 5 && gameObject.GetComponent<EnemyManager2>().i >= 5 && GameObject.FindGameObjectsWithTag("Enemy1").Length == 0 && GameObject.FindGameObjectsWithTag("Enemy2").Length == 0 || (player1.GetComponent<Movement>().isDead && player2.GetComponent<Movement>().isDead))
		{
			Application.LoadLevel ("pvp");
		}
	}
	

}
