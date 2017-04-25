using UnityEngine;
using System.Collections;

public class StartScreen : MonoBehaviour {

	public void LoadLevel(string level) {
		Application.LoadLevel(level);
	}
	
	public void QuitGame() {
		Debug.Log ("Quit Game!");
		Application.Quit();
	}
}
