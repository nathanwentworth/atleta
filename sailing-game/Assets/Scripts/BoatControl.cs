using UnityEngine;
using System.Collections;

public class BoatControl : MonoBehaviour {

	//SERIALZED FIELD VARIABLES

	//DECLARING PRIVATE VARIABLES
	private Rigidbody2D boatRigid;
	public bool moveNot;
	private bool moveSlow;
	private bool moveFast;
	private float boatSpeed;

	void Start () {

		//INITIALIZING VARIABLES
		boatRigid = this.GetComponent<Rigidbody2D> ();
		moveNot = true;
		moveSlow = false;
		moveFast = false;
		boatSpeed = 0;
	}

	void Update () {

		//BOAT ROTATION
		float moveY = Input.GetAxis ("Horizontal");
		if (moveY < 0) {
			transform.Rotate (35 * (-Vector3.forward * Time.deltaTime));
		} else if (moveY > 0) {
			transform.Rotate (35 * (Vector3.forward * Time.deltaTime));
		}

		//BOAT STOP
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			moveFast = false;
			moveSlow = false;
			moveNot = true;
		}
		if (moveNot) {
			boatSpeed = Mathf.Lerp (boatSpeed, 0, Time.deltaTime);
			boatRigid.velocity = transform.up * boatSpeed;
		}

		//BOAT SLOW SPEED
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			moveNot = false;
			moveFast = false;
			moveSlow = true;
			}
		if (moveSlow) {
			boatSpeed = Mathf.Lerp (boatSpeed, -0.5f, Time.deltaTime);
			boatRigid.velocity = transform.up * boatSpeed;
		}

		//BOAT FAST SPEED
		if (Input.GetKeyDown (KeyCode.Alpha3)) {
			moveNot = false;
			moveSlow = false;
			moveFast = true;
		}
		if (moveFast) {
			boatSpeed = Mathf.Lerp(boatSpeed, -1, Time.deltaTime);
			boatRigid.velocity = transform.up * boatSpeed;
		}
	}
}
