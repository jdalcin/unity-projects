using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int targetNum;
	int guessNum;
	
	// Use this for initialization
	void Start () {		
		max = 1000;
		min = 1;
		//targetNum = (int) (Random.value * (max - min) + min);
		targetNum = (int) (Random.value * (max - min) + min);
		guessNum = (int) (Random.value * (max - min) + min);
		print ("Welcome to Number Wizard.");
		print (targetNum);
		print ("I am thinking of an integer between " + min + " and " + max + ".");
		print ("Is the number " + guessNum + "?");
	}

	// Update is called once per frame
	void Update () {
		if (guessNum > targetNum) {
			max = guessNum - 1;
			print ("No. The number is less than " + guessNum + "."); 
		} else if (guessNum < targetNum) {
			min = guessNum + 1;
			print ("No. The number is greater than " + guessNum + ".");
		} else {
			print ("Yes! The number is: " + guessNum + ".");
		}
		guessNum = (int) (Random.value * (max - min) + min);
		print ("Is the number " + guessNum + "?");
	}
}
