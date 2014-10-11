using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float speed = 5.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Translate(Vector3.up*Time.deltaTime*speed);
		if (!transform.renderer.isVisible) Destroy (gameObject);
	
	}
}
