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
		
		player = GameObject.Find ("murderer");

		remainingAmmo = player.GetComponent<destroyer2> ().ammo;

		score = GetComponent<UnityEngine.UI.Text>();

		score.text = "Ammo: " + remainingAmmo;
	}


	void Update () {
		remainingAmmo = player.GetComponent<destroyer2> ().ammo;
		score.text = "Ammo: " + remainingAmmo;
	}
}
