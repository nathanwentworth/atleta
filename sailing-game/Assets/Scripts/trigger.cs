using UnityEngine;
using System.Collections;

public class trigger : MonoBehaviour {

	public GameObject book;
	public BoatControl BoatControl;
	public dialogue dialogue;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D target) {
		// BoatControl.boatSpeedSet = 0;
		if (target.gameObject.tag == "trigger-1") {
			Debug.Log("trigger 1 activated");
			dialogue.Script2A();
		}
	}
	void OnTriggerEnter2D(Collider2D target) {
		// move stop function call

		book.SetActive(true);
	}
}