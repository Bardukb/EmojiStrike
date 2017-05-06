using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class remaining : MonoBehaviour {

	UnityEngine.UI.Text score;
	public float remainingAmmo;

	GameObject player;

	// Use this for initialization
	void Start () {
		
		player = GameObject.Find ("Murderer");

		remainingAmmo = player.GetComponent<destroyer2> ().remainingAmmo;

		score = GetComponent<UnityEngine.UI.Text>();

		score.text = "Mag: " + remainingAmmo;
	}

	// Update is called once per frame
	void Update () {
		score.text = "Mag: " + remainingAmmo;
	}
}
