using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float speed = 5.0f;
	public float speed2 = .5f;
	public float damage;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Application.loadedLevelName == "peregrin's scene") transform.Translate(Vector3.up*Time.deltaTime*speed);
		else
		{
			if (transform.name == "P1Bullet(Clone)") transform.Translate (Vector3.right*speed2, Space.Self);
			else transform.Translate (Vector3.left*speed2, Space.Self);
			Vector3 pos = transform.position;
			pos.z = 0;
			transform.position = pos;
		}
		
		if (!transform.renderer.isVisible) Destroy (gameObject);
		
		GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy1");
		for (int i = 0; i < enemies.Length; i++)
		{
			if (enemies[i].collider2D.bounds.Intersects(gameObject.collider2D.bounds))
			{
				enemies[i].GetComponent<Enemy>().TakeDamage(damage);
				Destroy (gameObject);
			}
		}
		enemies = GameObject.FindGameObjectsWithTag("Enemy2");
		for (int i = 0; i < enemies.Length; i++)
		{
			if (enemies[i].collider2D.bounds.Intersects(gameObject.collider2D.bounds))
			{
				enemies[i].GetComponent<Enemy>().TakeDamage(damage);
				Destroy (gameObject);
			}
		}
	
	}
}
