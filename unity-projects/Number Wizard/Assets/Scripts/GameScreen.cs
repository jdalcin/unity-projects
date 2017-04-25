using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameScreen : MonoBehaviour {

	public Text number;
	public Text title;
	int min;
	int max;
	int guess;
	int maxGuessesAllowed;
	
	void Start() {
		min = 1;
		max = 1000;
		maxGuessesAllowed = 10;
		nextGuess();
	}
	
	public void ReturnToStart(string startScreen) {
		Application.LoadLevel(startScreen);
	}
	
	void nextGuess() {
		guess = Random.Range(min, max);
		number.text = "" + guess;
	}
	
	public void guessHigher(string winScreen) {
		min = guess + 1;
		nextGuess();
		--maxGuessesAllowed;
		if (maxGuessesAllowed == 0) {
			Application.LoadLevel(winScreen);
		}
		title.text = maxGuessesAllowed + " turns left.";
	}
	
	public void guessCorrect(string loseScreen) {
		Application.LoadLevel(loseScreen);
	}
	
	public void guessLower(string winScreen) {
		max = guess - 1;
		nextGuess();
		--maxGuessesAllowed;
		if (maxGuessesAllowed == 0) {
			Application.LoadLevel(winScreen);
		}
		title.text = maxGuessesAllowed + " turns left.";
	}
}
