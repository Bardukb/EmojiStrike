using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour {

	public int weaponSelection;

	public GameObject indic;

	// Use this for initialization
	void Start () {
		weaponSelection = 0;
		indic = GameObject.Find ("indicator");
	}
	
	// Update is called once per frame
	void Update () {

		//scroll weapons
		if (Input.GetKeyDown (KeyCode.W)) 
			weaponSelection = (weaponSelection + 1) % 3;


	}
}
