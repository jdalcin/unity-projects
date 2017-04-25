using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	
	public void LoadLevel(string level) {
		Application.LoadLevel(level);
		Brick.numBlocks = 0;
	}
	
	public void LoadNextLevel() {
		Application.LoadLevel(Application.loadedLevel + 1);
		Brick.numBlocks = 0;
	}
	
	public void QuitGame() {
		Debug.Log ("Quit Game!");
		Application.Quit();
	}
	
}
