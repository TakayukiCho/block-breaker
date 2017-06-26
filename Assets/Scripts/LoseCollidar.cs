using UnityEngine;
using System.Collections;

public class LoseCollidar : MonoBehaviour {

	private LevelManager levelmanager;
	
	
	void Start ( ) {
		levelmanager = GameObject.FindObjectOfType<LevelManager>();
	}

	// Use this for initialization
	void OnTriggerEnter2D (Collider2D trigger) {
		levelmanager.LoadLevel("Lose");
	}
}
