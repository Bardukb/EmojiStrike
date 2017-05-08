using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class writer : MonoBehaviour {

	UnityEngine.UI.Text score;
	float timePassed;

	// Use this for initialization
	void Start () {
		timePassed = 30;

		score = GetComponent<UnityEngine.UI.Text>();
	}
	
	// Update is called once per frame
	void Update () {
		timePassed -= Time.deltaTime;
		score.text = "Remaining time: " + ((int)timePassed) % 30;

		if (timePassed < 0) {



		}
		
	}
}
