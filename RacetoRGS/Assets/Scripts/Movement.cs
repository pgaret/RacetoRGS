using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	//Speed of movement
	public float speed = 10.0f;
	//Bullet to be fired
	public Transform bullet;
	
	//Attack Timer 1
	float attackCD1 = .2f;
	float attackTimer1;
	// Ship health 2
	public float shipHealth1 = 100.0f;
	// Multiplier for damage
	public float handicap1 = 1.0f;
	// Score
	public static float score1 = 0.0f;

	//Attacker Time 2
	float attackCD2 = .2f;
	float attackTimer2;
	// Ship health 2
	public float shipHealth2 = 100.0f;
	// Multiplier for damage
	public float handicap2 = 1.0f;
	// Score
	public static float score2 = 0.0f;

	// Who won the game?
	public static int winner = 0; //0 = undecided, 1 = player 1, 2 = player 2

	int playerNumber;

	const float EPSILON = 0.00001f;

	// Use this for initialization
	void Start () {
		//Check the tag on the GameObject to see whether the script is attached to Player1 or Player2
		if (gameObject.tag == "Player1") playerNumber = 1;
		else playerNumber = 2;
		
		attackTimer1 = Time.time;
		attackTimer2 = Time.time;
		
//		GetComponent<Animator>().speed = .1f;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (playerNumber == 1)
		{
			//Player1 movement based on input from WASD
			if (Input.GetKey(KeyCode.W)) transform.Translate(Vector3.up*Time.deltaTime*speed);
			if (Input.GetKey(KeyCode.A)) transform.Translate(Vector3.left*Time.deltaTime*speed);
			if (Input.GetKey(KeyCode.S)) transform.Translate(Vector3.down*Time.deltaTime*speed);
			if (Input.GetKey(KeyCode.D)) transform.Translate(Vector3.right*Time.deltaTime*speed);
			if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D)) transform.Translate (Vector3.up*Time.deltaTime);
			//Player1 fires a bullet with the left shift key
			if (Input.GetKey(KeyCode.LeftShift) && Time.time > attackTimer1)
			{
				Instantiate(bullet, transform.position, Quaternion.identity);
				attackTimer1 = Time.time + attackCD1;
			}
		}
		else
		{
			//Player2 movement based on arrow keys
			if (Input.GetKey(KeyCode.UpArrow)) transform.Translate(Vector3.up*Time.deltaTime*speed);
			if (Input.GetKey(KeyCode.LeftArrow)) transform.Translate(Vector3.left*Time.deltaTime*speed);
			if (Input.GetKey(KeyCode.DownArrow)) transform.Translate(Vector3.down*Time.deltaTime*speed);
			if (Input.GetKey(KeyCode.RightArrow)) transform.Translate(Vector3.right*Time.deltaTime*speed);
			if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow)) transform.Translate (Vector3.up*Time.deltaTime);
			//Player2 fires a bullet with the right shift key
			if (Input.GetKey(KeyCode.RightShift) && Time.time > attackTimer2)
			{
				Instantiate(bullet, transform.position, Quaternion.identity);
				attackTimer2 = Time.time + attackCD2;
			}

		}

		if (shipHealth2 <= EPSILON)
		{
			winner = 1;
			Application.LoadLevel("GameOver");
		} else if (shipHealth1 <= EPSILON) {
			winner = 2;
			Application.LoadLevel("GameOver");
		}
	}
}
