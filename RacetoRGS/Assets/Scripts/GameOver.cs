using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	public Texture gameOverTexture;

	void OnGUI()
	{
		var centeredStyle = GUI.skin.GetStyle("Label");
		centeredStyle.alignment = TextAnchor.UpperCenter;
//		GUI.TextField(new Rect(Screen.width / 2 - 75, Screen.height / 2 - 60, 150, 20),"Winner: Player " + Movement.winner.ToString() + "!", centeredStyle);
		GUI.TextField(new Rect(Screen.width / 2 - 75, Screen.height / 2 - 35, 150, 20),"Player 1 Score: " + Movement.score.ToString(), centeredStyle);
//		GUI.TextField(new Rect(Screen.width / 2 - 75, Screen.height / 2 - 10, 150, 20),"Player 2 Score: " + Movement.score2.ToString(), centeredStyle);

		var centeredButton = GUI.skin.GetStyle("Button");
		centeredButton.alignment = TextAnchor.MiddleCenter;

		if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2 + 25, 300, 25),"Revel once more in glorious combat!", centeredButton)) 
		{
//			Movement.winner = 0;
			Movement.score = 0.0f;
//			Movement.score2 = 0.0f;
			Application.LoadLevel("peregrin's scene");
		}
		if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2 + 50, 300, 25),"Fade into the distant memory of the cosmos.", centeredButton)) 
		{
			Application.Quit();
		}
	}
}