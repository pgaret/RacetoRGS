using UnityEngine;
using System.Collections;

public class Pvpmain : MonoBehaviour {

	public GameObject player1;
	public GameObject player2;

	// Use this for initialization
	void Start () {
	
	}
	
	void OnGUI()
	{
		GUI.skin.box.fontSize = 0;
		GUI.Box (new Rect(0, Screen.height * 7 / 8, Screen.width / 2, Screen.height / 8), "Player 1:  Health "+player1.GetComponent<PvP>().health
															+"Lives "+player1.GetComponent<PvP>().lives+" Damage "+player1.GetComponent<PvP>().damage+" ");
		GUI.Box (new Rect(Screen.width / 2, Screen.height * 7 / 8, Screen.width / 2, Screen.height / 8), "Player 1:  Health "+player2.GetComponent<PvP>().health
		         +"Lives "+player2.GetComponent<PvP>().lives+" Damage "+player2.GetComponent<PvP>().damage+" ");
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (player1.GetComponent<PvP>().isDead == true)
		{
			PlayerPrefs.SetInt("winner", 2);
			Application.LoadLevel("GameOver");
		}
		if (player2.GetComponent<PvP>().isDead == true)
		{
			PlayerPrefs.SetInt("winner", 1);
			Application.LoadLevel ("GameOver");
		}
	}
}
