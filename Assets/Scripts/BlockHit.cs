using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockHit : MonoBehaviour {
	[SerializeField] private float destroyDelay = 0.05f;
	[SerializeField] private ScoreManager scoreManager;

	private void OnCollisionEnter2D (Collision2D other) {
		// destroy the object with a delay of 50ms
		Destroy (gameObject, destroyDelay);
		// Debug.Log (other.gameObject.name);
		// update score
		scoreManager.incrementScore ();
	}
}
