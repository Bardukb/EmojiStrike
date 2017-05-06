using UnityEngine;

namespace Destructible2D
{
	// This component allows you to control a spaceship
	[RequireComponent(typeof(Rigidbody2D))]
	[AddComponentMenu(D2dHelper.ComponentMenuPrefix + "Player Spaceship")]
	public class destroy : MonoBehaviour
	{
		public GameObject BulletPrefab;

		public GameObject MuzzleFlashPrefab;

		public float ReloadTime;

		public float TurnSpeed;

		public float MoveSpeed;

		public float MaxThrusterScale;

		public float MaxThrusterFlicker;

		public Transform LeftGun;

		public Transform RightGun;

		public Transform LeftThruster;

		public Transform RightThruster;

		private float thrusterScale;

		private float cooldown;
		GameObject instanceOfPlayer;

		private int orientationValue;

		private int shotsFired;

		private Rigidbody2D mainRigidbody;

		void Start()
		{
			instanceOfPlayer = GameObject.Find ("murderer");
		}

		protected virtual void Update()
		{

			orientationValue = instanceOfPlayer.GetComponent<mover> ().orientation;

			// Cool down the gun
			cooldown -= Time.deltaTime;

			// Does the player want to shoot?
			if (Input.GetButton("Jump") == true)
			{
				// Is the gun ready to shoot?
				if (cooldown <= 0.0f)
				{
					
					cooldown    = ReloadTime;
					shotsFired += 1;

					// Find the muzzle position
					var muzzlePosition = transform.position;


					// Spawn bullet?
					if (BulletPrefab != null)
					{
						
						Instantiate(BulletPrefab, new Vector3(transform.position.x + 3* orientationValue  , transform.position.y , 0),  Quaternion.Euler(new Vector3(0, 0, -90 * orientationValue )));
					}

					// Spawn muzzle flash?
					if (MuzzleFlashPrefab != null)
					{
						Instantiate(MuzzleFlashPrefab, muzzlePosition,  Quaternion.Euler(new Vector3(0, 0, 1)));
					}
				}
			}
				
		}



	}
}