using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	// configuration parameters
	[SerializeField] Paddle paddle1;
	[SerializeField] Vector2 startingVelocity = new Vector2 (2f, 5f);
	private bool hasStarted = false;

	// state
	Vector2 paddleToBallVector;

	// Use this for initialization
	void Start () {
		paddleToBallVector = transform.position - paddle1.transform.position;
	}

	// Update is called once per frame
	void Update () {
		if (!hasStarted) {
			LockBallToPaddle ();
			LaunchOnMouseClick ();
		}
	}

	private void LockBallToPaddle () {
		if (hasStarted) {
			return;
		}
		Vector2 currPaddlePos = new Vector2 (paddle1.transform.position.x, paddle1.transform.position.y);
		transform.position = currPaddlePos + paddleToBallVector;
	}

	private void LaunchOnMouseClick () {
		if (Input.GetMouseButtonDown (0)) {
			hasStarted = true;
			GetComponent<Rigidbody2D> ().velocity = startingVelocity;
		}
	}
}
