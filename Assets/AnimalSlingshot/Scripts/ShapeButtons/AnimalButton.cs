using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnimalButton : MonoBehaviour {

	public int animal = 0;
	void Start () {


	}
	void Update () {
	}

	public void LoadShape(){
		AnimalSlingshot game = FindObjectOfType (typeof(AnimalSlingshot)) as AnimalSlingshot;
		try {
			Bullet CurrentBullet = game.GetLoaded ().GetComponent<Bullet> ();
			if (CurrentBullet != null && CurrentBullet.motion == false) {
				Destroy (game.GetLoaded ());
				game.SetCurrent (null);
			}
		} catch {
		}
		game.SetCurrent (game.Bullet);
		GameObject CurrentObj = game.GetCurrent ();
		GameObject shot = GameObject.Find ("Shot");
		if (shot != null) {
			shot.transform.localPosition = new Vector3 (0f, -.3f, 0f);
			GameObject current = Instantiate (CurrentObj) as GameObject;
			float x = shot.transform.position.x;
			float y = shot.transform.position.y;
			float z = shot.transform.position.z - 1;
			current.transform.localPosition = new Vector3(x, y, z);
			current.transform.localScale = new Vector2 (.4f, .4f);
			game.CShape = animal;
			current.GetComponent<Bullet> ().animal = animal;
			game.SetLoaded (current);
		}
	}
}
