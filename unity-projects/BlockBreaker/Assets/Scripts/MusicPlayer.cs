using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
	static MusicPlayer instance;
	
	void Awake() {
		if (instance == null) {
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		} else {
			GameObject.Destroy(gameObject);
		}
	}
	void Start() {
	
	}
	
	void Update() {
		
	}
}
