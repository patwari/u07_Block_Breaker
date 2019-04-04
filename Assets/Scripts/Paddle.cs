using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	[SerializeField] float screenWidthUnits = 16f;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		float mousePos = Input.mousePosition.x / Screen.width * screenWidthUnits;
		Vector2 paddlePos = new Vector2 (mousePos, transform.position.y);

		transform.position = paddlePos;
	}
}
