using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

	//Camera over blue ship
	public Camera camB;
	//Camera over red ship
	public Camera camR;
	//Enemy
	public Transform enemy;
	float createEnemy;
	
	// Use this for initialization
	void Start () {
		createEnemy = Time.time;
	}
	
	// Update is called once per frame
	void Update ()
	{	
		camB.transform.Translate(Vector3.up*Time.deltaTime);
		camR.transform.Translate(Vector3.up*Time.deltaTime);
	}
}
