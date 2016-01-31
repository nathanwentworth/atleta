using UnityEngine;
using System.Collections;

public class trigger : MonoBehaviour {

	public GameObject canvas;
	public GameObject book;
	public GameObject mainMenu;

	public BoatControl BoatControl;
	public dialogue dialogue;

	private float alphaTimer;
	private bool startTimer;

	public CanvasGroup fadeCanvasGroup;

	[SerializeField]
	private float speed;

	private bool textDisp;

	// Use this for initialization
	void Start () {
		BoatControl.inputEnabled = false;
		BoatControl.boatSpeedSet = 0;
	}

	void Update() {
		if (startTimer) {
			alphaTimer += Time.deltaTime;
	    fadeCanvasGroup.alpha -= speed * Time.deltaTime;
		}
		if (alphaTimer >= 2) {
			textDisp = true;
			canvas.GetComponent<Animator>().SetBool("textDisplay", textDisp);
			dialogue.S1();
			BoatControl.inputEnabled = true;
			mainMenu.SetActive(false);
			startTimer = false;
		}
	}

	public void GameStart() {
		startTimer = true;
	}

	void OnTriggerEnter2D(Collider2D target) {
		if (target.gameObject.tag == "trigger-1") {
			BoatControl.inputEnabled = false;
			BoatControl.boatSpeedSet = 0;
			book.SetActive(true);
			Debug.Log("trigger 1 activated");
			textDisp = true;
			Debug.Log(textDisp);
			canvas.GetComponent<Animator>().SetBool("textDisplay", textDisp);
			dialogue.K1();
		}
		if (target.gameObject.tag == "trigger-2") {
			BoatControl.inputEnabled = false;
			BoatControl.boatSpeedSet = 0;
			book.SetActive(true);
			Debug.Log("trigger 2 activated");
			canvas.GetComponent<Animator>().SetBool("textDisplay", textDisp);
			dialogue.K1();
		}
		if (target.gameObject.tag == "trigger-3") {
			BoatControl.inputEnabled = false;
			BoatControl.boatSpeedSet = 0;
			book.SetActive(true);
			Debug.Log("trigger 3 activated");
			canvas.GetComponent<Animator>().SetBool("textDisplay", textDisp);
			dialogue.K1();
		}
		if (target.gameObject.tag == "trigger-4") {
			BoatControl.inputEnabled = false;
			BoatControl.boatSpeedSet = 0;
			book.SetActive(true);
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