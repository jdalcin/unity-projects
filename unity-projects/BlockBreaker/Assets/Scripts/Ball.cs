using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	
	private Player player;
	private Vector3 ballToPlayer;
	private bool isStart;
	
	// Use this for initialization
	void Start () {
		player = GameObject.FindObjectOfType<Player>();
		ballToPlayer = this.transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (!isStart){
			this.transform.position = player.transform.position + ballToPlayer;
			if (Input.GetMouseButtonDown(0)) {
				isStart = true;
				Debug.Log ("Mouse Clicked, launch ball");
				this.rigidbody2D.velocity = new Vector2(2f, 10f);
			}
		}
	}
	
	void OnCollisionEnter2D(Collision2D collision) {
		if (isStart) {
			this.audio.Play();
		}
		this.rigidbody2D.velocity += new Vector2(Random.Range(0f,.2f), Random.Range(0f, .2f));
	}
}
