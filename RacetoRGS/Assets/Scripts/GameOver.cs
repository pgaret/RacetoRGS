using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour
{
	public Transform button	;
	public Transform hoverSprite;
	
	int winner;
	
	public void Start()
	{
		winner = PlayerPrefs.GetInt("winner");
	}
	
	void OnGUI()
	{
		GUI.Box (new Rect(Screen.width / 3, Screen.height / 2, Screen.width / 3, Screen.height / 5), "Player "+winner+" is the winner!\n\n\nA to go again, Y to quit");
	}
	
	public void Update()
	{
		if (Input.GetButton ("Fire4") || Input.GetButton ("Y2")) Application.Quit();
		if (Input.GetButton("Fire1") || Input.GetButton("Fire2"))
		{
			Application.LoadLevel("peregrin's scene");
		}
	}
	
	
}