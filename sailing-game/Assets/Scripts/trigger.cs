using UnityEngine;
using System.Collections;

public class trigger : MonoBehaviour {

	public GameObject canvas;
	public GameObject book;
	public BoatControl BoatControl;
	public dialogue dialogue;
	private bool textDisp;

	// Use this for initialization
	void Start () {
		textDisp = true;
		canvas.GetComponent<Animator>().SetBool("textDisplay", textDisp);
		dialogue.S1();
		BoatControl.inputEnabled = true;
	
	}

	void OnTriggerEnter2D(Collider2D target) {
		BoatControl.inputEnabled = false;
		BoatControl.boatSpeedSet = 0;
		book.SetActive(true);
		if (target.gameObject.tag == "trigger-1") {
			Debug.Log("trigger 1 activated");
			textDisp = true;
			Debug.Log(textDisp);
			canvas.GetComponent<Animator>().SetBool("textDisplay", textDisp);
			dialogue.K1();
		}
		if (target.gameObject.tag == "trigger-2") {
			Debug.Log("trigger 2 activated");
			canvas.GetComponent<Animator>().SetBool("textDisplay", textDisp);
			dialogue.K1();
		}
		if (target.gameObject.tag == "trigger-3") {
			Debug.Log("trigger 3 activated");
			canvas.GetComponent<Animator>().SetBool("textDisplay", textDisp);
			dialogue.K1();
		}
		if (target.gameObject.tag == "trigger-4") {
			Debug.Log("trigger 4 activated");
			canvas.GetComponent<Animator>().SetBool("textDisplay", textDisp);
			dialogue.K1();
		}
	}
	public void ClosePanel() {
		textDisp = false;
		canvas.GetComponent<Animator>().SetBool("textDisplay", textDisp);
		BoatControl.inputEnabled = true;
		BoatControl.boatSpeedSet = 0;
	}
}