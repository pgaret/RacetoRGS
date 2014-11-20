using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Main : MonoBehaviour {

	//Xamera over blue ship
	public Camera camB;
	//Xamera over red ship
	public Camera camR;
	//List of spots
	List<GameObject> spots = new List<GameObject>();
	// Use this for initialization
	void Start ()
	{
		spots.Add(GameObject.Find ("A0")); spots.Add(GameObject.Find ("A1"));spots.Add(GameObject.Find ("A2"));
		spots.Add(GameObject.Find ("A3")); spots.Add(GameObject.Find ("A4"));spots.Add(GameObject.Find ("A5"));
		spots.Add(GameObject.Find ("A6")); spots.Add(GameObject.Find ("A7"));spots.Add(GameObject.Find ("A8"));
		spots.Add(GameObject.Find ("B0")); spots.Add(GameObject.Find ("B1"));spots.Add(GameObject.Find ("B2"));
		spots.Add(GameObject.Find ("B3")); spots.Add(GameObject.Find ("B4"));spots.Add(GameObject.Find ("B5"));
		spots.Add(GameObject.Find ("B6")); spots.Add(GameObject.Find ("B7"));spots.Add(GameObject.Find ("B8"));
	}
	
	// Update is called once per frame
	void Update ()
	{	
		camB.transform.Translate(Vector3.up*Time.deltaTime);
		camR.transform.Translate(Vector3.up*Time.deltaTime);
		
		for (int i = 0; i < spots.Count; i++) spots[i].transform.Translate (Vector2.up*Time.deltaTime);
		
		
		
		if (Input.GetButtonUp("A1")) Debug.Log("A1");
		if (Input.GetButtonUp("B1")) Debug.Log("B1");
		if (Input.GetButtonUp("X1")) Debug.Log("X1");
		if (Input.GetButtonUp("Y1")) Debug.Log("Y1");
		
		if (Input.GetButtonUp("A2")) Debug.Log("A2");
		if (Input.GetButtonUp("B2")) Debug.Log("B2");
		if (Input.GetButtonUp("X2")) Debug.Log("X2");
		if (Input.GetButtonUp("Y2")) Debug.Log("Y2");
		
	}
	

}
