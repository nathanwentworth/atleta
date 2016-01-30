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
		BoatControl.boatSpeedSet = 0;
	}
	void OnTriggerEnter2D(Collider2D target) {
		book.SetActive(true);
		if (target.gameObject.tag == "trigger-1") {
			Debug.Log("trigger 1 activated");
			dialogue.Script2A();
		}
		if (target.gameObject.tag == "trigger-2") {
			Debug.Log("trigger 2 activated");
			dialogue.Script2A();
		}
		if (target.gameObject.tag == "trigger-3") {
			Debug.Log("trigger 3 activated");
			dialogue.Script2A();
		}
		if (target.gameObject.tag == "trigger-4") {
			Debug.Log("trigger 4 activated");
			dialogue.Script2A();
		}

	}
}