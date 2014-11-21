using UnityEngine;
using System.Collections;

public class PvP : MonoBehaviour {

	public int speed;
	public int damage;
	public int spread;
	public int health;
	public int lives;
	
	public int playerNumber;
	public float rotateSpeed;
	
	public Transform bullet;
	
	public float attackCD;
	float attackTimer;
	
	private float tiltAngle = 30;
	
	GameObject top;
	GameObject down;
	GameObject left;
	GameObject right;

	// Use this for initialization
	void Start ()
	{
		top = GameObject.Find ("Top");
		down = GameObject.Find ("Down");
		left = GameObject.Find ("Left");
		right = GameObject.Find ("Right");
		
		if (playerNumber == 1)
		{
			damage = PlayerPrefs.GetInt("player1damage");
			health = PlayerPrefs.GetInt ("player1health");
			lives = PlayerPrefs.GetInt ("player1lives");
			spread = PlayerPrefs.GetInt ("player1spread");
		}
		
		else
		{
			damage = PlayerPrefs.GetInt("player2damage");
			health = PlayerPrefs.GetInt ("player2health");
			lives = PlayerPrefs.GetInt ("player2lives");
			spread = PlayerPrefs.GetInt ("player2spread");
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (playerNumber == 1)
		{
			//Player1 movement
			if (Input.GetAxis("Vertical1") > 0 && transform.position.y < top.transform.position.y) transform.Translate(Vector3.up*Time.deltaTime*speed, Space.World);
			if (Input.GetAxis ("Horizontal1") < 0 && transform.position.x > left.transform.position.x) transform.Translate(Vector3.left*Time.deltaTime*speed, Space.World);
			if (Input.GetAxis ("Vertical1") < 0 && transform.position.y > down.transform.position.y) transform.Translate(Vector3.down*Time.deltaTime*speed, Space.World);
			if (Input.GetAxis ("Horizontal1") > 0 && transform.position.x < right.transform.position.x) transform.Translate(Vector3.right*Time.deltaTime*speed, Space.World);
			//Player rotation
			float rotateTo = transform.localRotation.z + 10;
			if (Input.GetAxis("Rotate1") > 0) transform.Rotate (Vector3.forward*rotateSpeed);
			if (Input.GetAxis("Rotate1") < 0) transform.Rotate (-Vector3.forward*rotateSpeed);
			//Player1 fires a bullet with the left shift key
			if (Input.GetButton ("Fire1") && Time.time > attackTimer)
			{
				Transform thebullet = (Transform)Instantiate(bullet, transform.position, Quaternion.identity);
				thebullet.GetComponent<Bullet>().damage = damage;
				thebullet.rotation = transform.rotation;
				attackTimer = Time.time + attackCD;
			}
			
			GameObject[] bullets = GameObject.FindGameObjectsWithTag("Bullet2");
			for (int i = 0; i < bullets.Length; i++)
			{
				if (bullets[i].renderer.bounds.Intersects(renderer.bounds))
				{
					health -= 1;
					Destroy (bullets[i].gameObject);
				}
			}
		}
		else
		{
			//Player2 movement based on arrow keys
			if (Input.GetAxis("Vertical2") > 0 && transform.position.y < top.transform.position.y) transform.Translate(Vector3.up*Time.deltaTime*speed, Space.World);
			if (Input.GetAxis ("Horizontal2") < 0 && transform.position.x > left.transform.position.x) transform.Translate(Vector3.left*Time.deltaTime*speed, Space.World);
			if (Input.GetAxis ("Vertical2") < 0 && transform.position.y > down.transform.position.y) transform.Translate(Vector3.down*Time.deltaTime*speed, Space.World);
			if (Input.GetAxis ("Horizontal2") > 0 && transform.position.x < right.transform.position.x) transform.Translate(Vector3.right*Time.deltaTime*speed, Space.World);
			//Player rotation
			float rotateTo = transform.localRotation.z + 10;
			if (Input.GetAxis("Rotate2") > 0) transform.Rotate (Vector3.forward*rotateSpeed);
			if (Input.GetAxis("Rotate2") < 0) transform.Rotate (-Vector3.forward*rotateSpeed);
			//Player2 fires a bullet with the right shift key
			if (Input.GetButton("Fire2") && Time.time > attackTimer)
			{
				Transform thebullet = (Transform)Instantiate(bullet, transform.position, Quaternion.identity);
				thebullet.GetComponent<Bullet>().damage = damage;
				thebullet.rotation = transform.rotation;
				attackTimer = Time.time + attackCD;
			}
			
			GameObject[] bullets = GameObject.FindGameObjectsWithTag("Bullet1");
			for (int i = 0; i < bullets.Length; i++)
			{
				if (bullets[i].renderer.bounds.Intersects(renderer.bounds))
				{
					health -= 1;
					Destroy (bullets[i].gameObject);
				}
			}
		}
	}
}
