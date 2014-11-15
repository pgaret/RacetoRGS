using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	//Speed of movement
	public float speed = 10.0f;
	//Bullet to be fired
	public Transform bullet;
	// Cooldown time for bullets
	public float cooldown = 0.5f;
	public float cooldownTimer = 0.5f;
	// Duration of bullets
	public float bulletLife = 0.1f;

	int playerNumber;

	// Use this for initialization
	void Start () {
	
		//Check the tag on the GameObject to see whether the script is attached to Player1 or Player2
		if (gameObject.tag == "Player1") playerNumber = 1;
		else playerNumber = 2;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (cooldownTimer > 0) {
			cooldownTimer -= Time.deltaTime;
		}
		if (playerNumber == 1)
		{
			//Player1 movement based on input from WASD
			if (Input.GetKey(KeyCode.W)) transform.Translate(Vector3.up*Time.deltaTime*speed);
			if (Input.GetKey(KeyCode.A)) transform.Translate(Vector3.left*Time.deltaTime*speed);
			if (Input.GetKey(KeyCode.S)) transform.Translate(Vector3.down*Time.deltaTime*speed);
			if (Input.GetKey(KeyCode.D)) transform.Translate(Vector3.right*Time.deltaTime*speed);
			//Player1 fires a bullet with the left shift key
			if (Input.GetKey(KeyCode.LeftShift)) StartCoroutine(FireOneShot());
		}
		else
		{
			//Player2 movement based on arrow keys
			if (Input.GetKey(KeyCode.UpArrow)) transform.Translate(Vector3.up*Time.deltaTime*speed);
			if (Input.GetKey(KeyCode.LeftArrow)) transform.Translate(Vector3.left*Time.deltaTime*speed);
			if (Input.GetKey(KeyCode.DownArrow)) transform.Translate(Vector3.down*Time.deltaTime*speed);
			if (Input.GetKey(KeyCode.RightArrow)) transform.Translate(Vector3.right*Time.deltaTime*speed);
			//Player2 fires a bullet with the right shift key
			if (Input.GetKey(KeyCode.RightShift)) StartCoroutine(FireOneShot());
		}

	
	}

	IEnumerator FireOneShot() {
		// What happens when a shot is fired
		if (cooldownTimer <= 0) {
			//Debug.Log ("Can shoot!");
			var bulletPos = transform.position;
			var newBullet = Instantiate (bullet, bulletPos, Quaternion.identity);
			cooldownTimer = cooldown;
			yield return new WaitForSeconds (bulletLife);
			Destroy (newBullet); // This still doesn't seem to work.
		} //else
			//Debug.Log ("Can't shoot!");
	}	
}