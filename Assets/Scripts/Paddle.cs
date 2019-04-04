using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	[SerializeField] float screenWidthUnits = 16f;
	[SerializeField] float clampMin = 1.02f;
	[SerializeField] float clampMax = 14.85f;
	[SerializeField] float defaultYPos = 0.25f;
	// Use this for initialization
	void Start () {
		transform.position = new Vector2 (transform.position.x, defaultYPos);
	}

	// Update is called once per frame
	void Update () {
		float mousePos = Input.mousePosition.x / Screen.width * screenWidthUnits;
		Vector2 paddlePos = new Vector2 (transform.position.x, transform.position.y);
		paddlePos.x = Mathf.Clamp (mousePos, clampMin, clampMax - clampMin);
		Debug.Log (paddlePos.x);
		transform.position = paddlePos;
	}
}
