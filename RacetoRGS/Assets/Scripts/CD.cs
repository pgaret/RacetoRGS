using UnityEngine;
using System.Collections;

public class CD : MonoBehaviour {

	public float length;
	float timer;

	// Use this for initialization
	void Start ()
	{
		timer = Time.time + length;
	}
	
	void OnGUI()
	{
		GUI.skin.box.fontSize = 48;
		float cd = Mathf.Round (timer - Time.time);
		GUI.Box (new Rect(Screen.width * 2 / 3, Screen.height / 2, Screen.width / 5, Screen.height / 5), cd.ToString());
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Time.time > timer) Application.LoadLevel("peregrin's scene");
	}
}
