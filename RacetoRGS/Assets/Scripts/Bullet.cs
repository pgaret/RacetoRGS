using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float speed = 5.0f;
	public int damage;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Translate(Vector3.up*Time.deltaTime*speed);
		if (!transform.renderer.isVisible) Destroy (gameObject);
		
		GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy1");
		for (int i = 0; i < enemies.Length; i++)
		{
			if (enemies[i].collider2D.bounds.Intersects(gameObject.collider.bounds))
			{
				enemies[i].GetComponent<Enemy>().TakeDamage(damage);
				Destroy (gameObject);
			}
		}
	
	}
}
