using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public Transform enemyBullet;
	public float firingRate;
	float timer;

	// Use this for initialization
	void Start ()
	{
		timer = Time.time;	
	}
	
	public void OnCreation(GameObject bounds)
	{
		float newX = Random.Range (bounds.transform.position.x - bounds.collider2D.bounds.extents.x, bounds.transform.position.x + bounds.collider2D.bounds.extents.x);
		float newY = Random.Range (bounds.transform.position.y - bounds.collider2D.bounds.extents.y, bounds.transform.position.y + bounds.collider2D.bounds.extents.y);
		
		transform.position = new Vector3(newX, newY);

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Time.time > timer)
		{
			Vector3 bulletPosition = new Vector3(transform.position.x, transform.position.y - transform.renderer.bounds.extents.y);
			Instantiate (enemyBullet, bulletPosition, Quaternion.identity);
			timer = Time.time + firingRate;
		}
	}
}
