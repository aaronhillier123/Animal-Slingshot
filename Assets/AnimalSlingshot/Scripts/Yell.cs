using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Yell : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public IEnumerator appear(int word, Color color) {
		switch (word) {
		case 0:
			gameObject.GetComponent<Text> ().text = "Meow!";
			break;
		case 1:
			gameObject.GetComponent<Text> ().text = "Ruff!";
			break;
		case 2:
			gameObject.GetComponent<Text> ().text = "Oink!";
			break;
		case 3:
			gameObject.GetComponent<Text> ().text = "Reee!";
			break;
		case 4: 
			gameObject.GetComponent<Text> ().text = "Oops!";
			break;
		default:
			gameObject.GetComponent<Text> ().text = "Hmm!";
			break;
		}
		gameObject.GetComponent<Text> ().color = color;
		yield return new WaitForSeconds (.5f);
		Destroy (gameObject);
	}
}
