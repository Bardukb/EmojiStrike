using UnityEngine;
using System.Collections;

public class mover : MonoBehaviour {

	public float speed;             //Floating point variable to store the player's movement speed.
	public int ammo;
	public int orientation;
	public float cooldown;

	private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.

	// Use this for initialization
	void Start()
	{
		//Get and store a reference to the Rigidbody2D component so that we can access it.
		rb2d = GetComponent<Rigidbody2D> ();
		orientation = -1;
		ammo = 100;
	}

	//FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
	void FixedUpdate()
	{
		//Store the current horizontal input in the float moveHorizontal.
		float moveHorizontal = Input.GetAxis ("Horizontal");

		//Store the current vertical input in the float moveVertical.
		float moveVertical = Input.GetAxis ("Vertical");


		cooldown -= Time.deltaTime;

		if (Input.GetKeyDown (KeyCode.UpArrow) && cooldown <= 0.0f) {
			transform.Translate (0, 2, 0);
			cooldown    = 1;
		}

		//Use the two store floats to create a new Vector2 variable movement.
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

		if(rb2d.velocity.magnitude > 100)
		{
			rb2d.velocity = rb2d.velocity.normalized * 100;
		}


		if(Input.GetKeyDown (KeyCode.F))
		{
			// flip the x scale
			transform.localScale = new Vector3(transform.localScale.x *-1, transform.localScale.y, transform.localScale.z);
			orientation *= -1;
		}

		//Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
		rb2d.AddForce (movement * speed);
	}
}