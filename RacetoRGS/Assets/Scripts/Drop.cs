using UnityEngine;
using System.Collections;

public class Drop : MonoBehaviour {

	public int type;
	public Sprite[] dropSprites;
	
	GameObject player1;
	GameObject player2;

	// Use this for initialization
	void Start ()
	{
		player1 = GameObject.Find ("playerone");
		player2 = GameObject.Find ("playertwo");
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (type != -1)
		{
			GetComponent<SpriteRenderer>().sprite = dropSprites[type];
		}
		if (player1.renderer.bounds.Intersects(renderer.bounds))
		{
			if (type == 1) player1.GetComponent<Movement>().damage += .2f;
			if (type == 2) player1.GetComponent<Movement>().shipHealth += 25;
			if (type == 3) player1.GetComponent<Movement>().lives += 1;
			if (type == 4) player1.GetComponent<Movement>().spread += 1;
			if (type == 5) player1.GetComponent<Movement>().damage += .2f;
			if (type == 6) player1.GetComponent<Movement>().shipHealth += 25;
			if (type == 7) player1.GetComponent<Movement>().lives += 1;
			if (type == 8) player1.GetComponent<Movement>().spread += 1;
			if (type == 9) player1.GetComponent<Movement>().damage += .2f;
			if (type == 10) player1.GetComponent<Movement>().shipHealth += 25;
			if (type == 11) player1.GetComponent<Movement>().lives += 1;
			if (type == 12) player1.GetComponent<Movement>().spread += 1;
			if (type == 13) player1.GetComponent<Movement>().damage += .2f;
			if (type == 14) player1.GetComponent<Movement>().shipHealth += 25;
			if (type == 15) player1.GetComponent<Movement>().lives += 1;
			if (type == 16) player1.GetComponent<Movement>().spread += 1;
			player1.GetComponent<Movement>().bonuses.Add (type);
			Destroy (gameObject);
		}
		if (player2.renderer.bounds.Intersects(renderer.bounds))
		{
			if (type == 1) player2.GetComponent<Movement>().damage += .2f;
			if (type == 2) player2.GetComponent<Movement>().shipHealth += 25;
			if (type == 3) player2.GetComponent<Movement>().lives += 1;
			if (type == 4) player2.GetComponent<Movement>().spread += 1;
			if (type == 5) player2.GetComponent<Movement>().damage += .2f;
			if (type == 6) player2.GetComponent<Movement>().shipHealth += 25;
			if (type == 7) player2.GetComponent<Movement>().lives += 1;
			if (type == 8) player2.GetComponent<Movement>().spread += 1;
			if (type == 9) player2.GetComponent<Movement>().damage += .2f;
			if (type == 10) player2.GetComponent<Movement>().shipHealth += 25;
			if (type == 11) player2.GetComponent<Movement>().lives += 1;
			if (type == 12) player2.GetComponent<Movement>().spread += 1;
			if (type == 13) player2.GetComponent<Movement>().damage += .2f;
			if (type == 14) player2.GetComponent<Movement>().shipHealth += 25;
			if (type == 15) player2.GetComponent<Movement>().lives += 1;
			if (type == 16) player2.GetComponent<Movement>().spread += 1;
			player1.GetComponent<Movement>().bonuses.Add (type);
			Destroy (gameObject);
		}
	}
}
