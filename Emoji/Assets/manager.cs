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
		if (Input.GetKeyDown (KeyCode.W)) {
			weaponSelection = (weaponSelection + 1) % 3;



			if (weaponSelection == 1) {
				
				indic.transform.position = new Vector3 ((indic.transform.position.x + 3.5f), indic.transform.position.y, 0);

			}
			else if (weaponSelection == 2) {

				indic.transform.position = new Vector3 ((indic.transform.position.x + 3.3f), indic.transform.position.y, 0);
			}

			else if (weaponSelection == 0 ) {

				indic.transform.position = new Vector3 ((indic.transform.position.x - 6.8f), indic.transform.position.y, 0);

			}

		}


	}
}
