using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	//Speed of movement
	public float speed = 10.0f;
	//Bullet to be fired
	public Transform bullet;

	int playerNumber;

	// Use this for initialization
	void Start () {
	
		//Check the tag on the GameObject to see whether the script is attached to Player1 or Player2
		if (gameObject.tag == "Player1") playerNumber = 1;
		else playerNumber = 2;
	
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
			//Player1 fires a bullet with the left shift key
			if (Input.GetKey(KeyCode.LeftShift)) Instantiate(bullet, transform.position, Quaternion.identity);
		}
		else
		{
			//Player2 movement based on arrow keys
			if (Input.GetKey(KeyCode.UpArrow)) transform.Translate(Vector3.up*Time.deltaTime*speed);
			if (Input.GetKey(KeyCode.LeftArrow)) transform.Translate(Vector3.left*Time.deltaTime*speed);
			if (Input.GetKey(KeyCode.DownArrow)) transform.Translate(Vector3.down*Time.deltaTime*speed);
			if (Input.GetKey(KeyCode.RightArrow)) transform.Translate(Vector3.right*Time.deltaTime*speed);
			//Player2 fires a bullet with the right shift key
			if (Input.GetKey(KeyCode.RightShift)) Instantiate(bullet, transform.position, Quaternion.identity);
		}

	
	}
}
