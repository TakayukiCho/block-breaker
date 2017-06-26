using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {


	private Paddle paddle;
	private Vector3 paddleToBallVector;
	private bool IsStarted = false;

	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle>();
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (!IsStarted){
			this.transform.position = paddle.transform.position + paddleToBallVector;
			if (Input.GetMouseButtonDown(0)){
				this.rigidbody2D.velocity = new Vector2(2f, 10f);
				IsStarted = true;
			}	
		}
	}
	
	void OnCollisionEnter2D(Collision2D col){
		Vector2 tweak = new Vector2(Random.Range(0f, 0.2f),Random.Range(0f, 0.2f));
		this.rigidbody2D.velocity += tweak;
	}

}
