using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Movement : MonoBehaviour {

	//Speed of movement
	public float speed;
	//Bullet to be fired
	public Transform bullet;
	//Attack Timer
	public float attackRate = 0;
	float attackCD = .2f;
	float attackTimer;
	// Ship health
	public float shipHealth = 100.0f;
	public float lives = 5;
	// Score
	public float score = 0.0f;
	//Damage per shot
	public float damage;
	//Shots shots shots shots shots
	public int spread;
	//Add-ons & sound
	GameObject infinite;
	//Am I dead yet?
	public bool isDead = false;
	//Boundaries for movement
	public GameObject top;
	public GameObject down;
	public GameObject left;
	public GameObject right;
	
	int playerNumber;

	// Use this for initialization
	void Start () {
		//Check the tag on the GameObject to see whether the script is attached to Player1 or Player2
		if (gameObject.tag == "Player1") playerNumber = 1;
		else playerNumber = 2;
		
		attackTimer = Time.time;
		
		if (playerNumber == 1)
		{
			top = GameObject.Find ("Top1");
			down = GameObject.Find ("Down1");
			left = GameObject.Find ("Left1");
			right = GameObject.Find ("Right1");
		}
		else
		{
			top = GameObject.Find ("Top2");
			down = GameObject.Find ("Down2");
			left = GameObject.Find ("Left2");
			right = GameObject.Find ("Right2");
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		attackRate = 1 / attackCD;
		
		GameObject[] bullets = GameObject.FindGameObjectsWithTag("EnemyBullet");
		{
			for (int i = 0; i < bullets.Length; i++)
			{
				if (bullets[i].collider2D.bounds.Intersects(gameObject.collider2D.bounds))
				{
					if (bullets[i].name == "EnemyBullet(Clone)") shipHealth -= 50;
					else shipHealth -= 25;
					Destroy (bullets[i].gameObject);
				}
				
			}
		}
		if (lives > 0 && shipHealth <= 0)
		{
			lives -= 1;
			shipHealth = 100;
		}
		if (lives <= 0 && shipHealth <= 0)
		{
			isDead = true;
		}
		
		if (playerNumber == 1)
		{
			//Player1 movement
			if (Input.GetAxis("Vertical1") > 0 && transform.position.y < top.transform.position.y) transform.Translate(Vector3.up*Time.deltaTime*speed);
			if (Input.GetAxis ("Horizontal1") < 0 && transform.position.x > left.transform.position.x) transform.Translate(Vector3.left*Time.deltaTime*speed);
			if (Input.GetAxis ("Vertical1") < 0 && transform.position.y > down.transform.position.y) transform.Translate(Vector3.down*Time.deltaTime*speed);
			if (Input.GetAxis ("Horizontal1") > 0 && transform.position.x < right.transform.position.x) transform.Translate(Vector3.right*Time.deltaTime*speed);
			if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D)) transform.Translate (Vector3.up*Time.deltaTime);
			//Player1 fires a bullet with the left shift key
			if (Time.time > attackTimer)
			{
				Transform thebullet = (Transform)Instantiate(bullet, transform.position, Quaternion.identity);
				thebullet.GetComponent<Bullet>().damage = damage;
				attackTimer = Time.time + attackCD;
			}
		}
		else
		{
			//Player2 movement based on arrow keys
			if (Input.GetAxis("Vertical2") > 0 && transform.position.y < top.transform.position.y) transform.Translate(Vector3.up*Time.deltaTime*speed);
			if (Input.GetAxis ("Horizontal2") < 0 && transform.position.x > left.transform.position.x) transform.Translate(Vector3.left*Time.deltaTime*speed);
			if (Input.GetAxis ("Vertical2") < 0 && transform.position.y > down.transform.position.y) transform.Translate(Vector3.down*Time.deltaTime*speed);
			if (Input.GetAxis ("Horizontal2") > 0 && transform.position.x < right.transform.position.x) transform.Translate(Vector3.right*Time.deltaTime*speed);
			if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow)) transform.Translate (Vector3.up*Time.deltaTime);
			//Player2 fires a bullet with the right shift key
			if (Time.time > attackTimer)
			{
				Transform thebullet = (Transform)Instantiate(bullet, transform.position, Quaternion.identity);
				thebullet.GetComponent<Bullet>().damage = damage;
				attackTimer = Time.time + attackCD;
			}
		}
	}
}
