using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

	[SerializeField] int currScore;
	// [SerializeField] int totalCount;
	[SerializeField] TextMeshProUGUI scoreText;

	// Use this for initialization
	private void Start () {
		// totalCount = 100;
		scoreText = GetComponent<TextMeshProUGUI> () ? GetComponent<TextMeshProUGUI> () : GameObject.Find ("Score").GetComponent<TextMeshProUGUI> ();
	}

	public void incrementScore (int num = 1) {
		currScore += num;
	}

	public void resetScore () {
		currScore = 0;
	}

	private void Update () {
		scoreText.SetText ("Score: " + currScore.ToString ());
		// scoreText.SetText ("Score: " + currScore.ToString () + "/" + totalCount.ToString ());
	}
}
