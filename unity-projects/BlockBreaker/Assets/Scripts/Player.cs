using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
		this.transform.position = new Vector3(Mathf.Clamp(mousePosInBlocks, 1f, 15f), this.transform.position.y, 0f);
	}
}
