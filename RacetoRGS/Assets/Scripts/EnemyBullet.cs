﻿using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Translate (Vector3.down*Time.deltaTime*speed);
	}
}
