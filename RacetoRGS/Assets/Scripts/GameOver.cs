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
		GUI.Box (new Rect(Screen.width / 3, Screen.height / 2, Screen.width / 3, Screen.height / 5), "Player "+winner+" is the winner!");
	}
	
	public void Update()
	{

	}
	
	
}