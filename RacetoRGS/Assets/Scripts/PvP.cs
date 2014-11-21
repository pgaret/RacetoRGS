using UnityEngine;
using System.Collections;

public class PvP : MonoBehaviour {

	public int speed;
	public int damage;
	public int spread;
	public float health;
	public int lives;
	
	private float maxHealth;
	
	public bool isDead = false;
	
	public int playerNumber;
	public float rotateSpeed;
	
	public Transform bullet;
	
	public float attackCD;
	float attackTimer;
	
	private float tiltAngle = 30;
	
	GameObject data;
	
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
		
		data = GameObject.Find ("Theme");
		
		if (playerNumber == 1)
		{
			for (int i = 0; i < data.GetComponent<Data>().player1Stats.Count; i++)
			{
				if (i == 0 || i == 4 || i == 8 || i == 12) lives += 1;
				if (i == 1 || i == 5 || i == 9 || i == 13) health += 20;
				if (i == 2 || i == 6 || i == 10 || i == 14) damage += 1;
				if (i == 3 || i == 7 || i == 11 || i == 15) spread += 1;
			}
		}
		
		else
		{
			for (int i = 0; i < data.GetComponent<Data>().player2Stats.Count; i++)
			{
				if (i == 0 || i == 4 || i == 8 || i == 12) lives += 1;
				if (i == 1 || i == 5 || i == 9 || i == 13) health += 20;
				if (i == 2 || i == 6 || i == 10 || i == 14) damage += 1;
				if (i == 3 || i == 7 || i == 11 || i == 15) spread += 1;
			}
		}
		
		maxHealth = health;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (health <= 0 && lives > 0)
		{
			lives -= 1;
			health = maxHealth;
		}
		if (lives <= 0 && health <= 0) isDead = true;
	
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
					health -= bullets[i].GetComponent<Bullet>().damage;
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
					health -= bullets[i].GetComponent<Bullet>().damage;
					Destroy (bullets[i].gameObject);
				}
			}
		}
	}
}
