using UnityEngine;
using System.Collections;

public class Survival : MonoBehaviour {


	private AnimalSlingshot game;

	void Start () {
		game = FindObjectOfType (typeof(AnimalSlingshot)) as AnimalSlingshot;


	}
	
	public void AStart(){
		game.GoodScore = 0;
		game.GoodScoreText.text = "Score: " + game.GoodScore.ToString ();
		game.BadScore = 60;
		InvokeRepeating ("Times", 0.1f, 0.1f);
	}

	void Update () {
		
	}

	void Times(){
			game.BadScore -= 0.1f;
			game.BadScoreText.text = game.BadScore.ToString ();
		if (game.BadScore <= 0) {
			game.end();
		}
	}
}
