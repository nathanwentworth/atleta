using UnityEngine;
using System.Collections;

public class BoatControl : MonoBehaviour {

	//SERIALZED FIELD VARIABLES

	//DECLARING PRIVATE VARIABLES
	private Rigidbody2D boatRigid;
	private float boatSpeed;
	public int boatSpeedSet;

	void Start () {

		//INITIALIZING VARIABLES
		boatRigid = this.GetComponent<Rigidbody2D> ();
		boatSpeed = 0;
		boatSpeedSet = 0;
	}

	void Update () {

		//BOAT ROTATION
		float moveY = Input.GetAxis ("Horizontal");
		if (moveY < 0) {
			transform.Rotate (35 * (-Vector3.forward * Time.deltaTime));
		} else if (moveY > 0) {
			transform.Rotate (35 * (Vector3.forward * Time.deltaTime));
		}

		//BOAT SPEED SET INPUT
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			boatSpeedSet = 0;
		}
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			boatSpeedSet = 1;
		}
		if (Input.GetKeyDown (KeyCode.Alpha3)) {
			boatSpeedSet = 2;
		}
			
		switch (boatSpeedSet) {
		case 0:
			BoatStop ();
			break;
		case 1:
			BoatSlow ();
			break;
		case 2:
			BoatFast ();
			break;
		}

		//END UPDATE
	}

	private void BoatStop(){
		boatSpeed = Mathf.Lerp (boatSpeed, 0, Time.deltaTime);
		boatRigid.velocity = transform.up * boatSpeed;
	}

	private void BoatSlow(){
		boatSpeed = Mathf.Lerp (boatSpeed, -0.5f, Time.deltaTime);
		boatRigid.velocity = transform.up * boatSpeed;
	}

	private void BoatFast(){
		boatSpeed = Mathf.Lerp (boatSpeed, -1, Time.deltaTime);
		boatRigid.velocity = transform.up * boatSpeed;
	}
}
