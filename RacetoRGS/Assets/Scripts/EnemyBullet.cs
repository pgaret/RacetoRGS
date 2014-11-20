using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!renderer.isVisible) Destroy(gameObject);
	
		transform.Translate (Vector3.down*Time.deltaTime*speed);
	}
}
