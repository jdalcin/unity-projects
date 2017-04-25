using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
	
	private int maxHit;
	public Sprite[] hitAnimations;
	private int timesHit;
	private LevelManager levelManager;
	public static int numBlocks;
	
	// Use this for initialization
	void Start () {
		maxHit = hitAnimations.Length;
		timesHit = 0;
		numBlocks = numBlocks + 1;
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter2D(Collision2D collision) {
		if (timesHit >= maxHit) {
			numBlocks--;
			print(numBlocks);
			if (numBlocks <= 0) {
				levelManager.LoadNextLevel();
			}
			GameObject.Destroy(gameObject);
		} else {
			this.GetComponent<SpriteRenderer>().sprite = hitAnimations[timesHit];
		}
		timesHit++;
	}
}
