using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class trigger : MonoBehaviour {

	public GameObject canvas;
	public GameObject book;
	public GameObject mainMenu;

	public Sprite flag0;
	public Sprite flag1;
	public Sprite flag2;
	public Sprite flag3;

	public AudioSource BoatSmash;

	public BoatControl BoatControl;
	public dialogue dialogue;

	private float alphaTimer;
	private bool startTimer;

	public int activateT4;
	private float endTimer;
	private bool startEndTimer;
	private bool spawnTrigger4;

	private Vector2 initialPos;

	public CanvasGroup fadeCanvasGroup;

	[SerializeField]
	private float speed;

	[SerializeField]
	private GameObject trigger4;

	private bool textDisp;

	// Use this for initialization
	void Start () {
		initialPos = new Vector2 (transform.position.x, transform.position.y);
		activateT4 = -1;
		BoatControl.inputEnabled = false;
		BoatControl.boatSpeedSet = 0;
		startEndTimer = false;
	}

	void Update() {
		if (startTimer) {
			alphaTimer += Time.deltaTime;
	    	fadeCanvasGroup.alpha -= speed * Time.deltaTime;
		}
		if (alphaTimer >= 2) {
			textDisp = true;
			canvas.GetComponent<Animator>().SetBool("textDisplay", textDisp);
			mainMenu.SetActive(false);
			startTimer = false;
			alphaTimer = 0;
		}

		if (startEndTimer) {
			print ("starting timer...");
			endTimer += Time.deltaTime;
		}

		if (endTimer >= 2) {
			print ("main menu loading...");
			textDisp = false;
			canvas.GetComponent<Animator>().SetBool("textDisplay", textDisp);
			mainMenu.SetActive (true);
			fadeCanvasGroup.alpha += speed * Time.deltaTime;
		}

		if (endTimer >= 6) {
			print ("reloading game");
			SceneManager.LoadScene (0);
		}

		if (activateT4 == 3) {
			trigger4.SetActive(true);
			activateT4 = -1;
			GetComponent<SpriteRenderer> ().sprite = flag3;
		}

		switch (activateT4) {
		case 1:
			GetComponent<SpriteRenderer> ().sprite = flag1;
			break;
		case 2:
			GetComponent<SpriteRenderer> ().sprite = flag2;
			break;
		case 3:
			GetComponent<SpriteRenderer> ().sprite = flag3;
			break;
		default:
			break;
		}
	}

	public void GameStart() {
		startTimer = true;
		// dialogue.S1();
	}

	void OnCollisionEnter2D(Collision2D collide){
		if (collide.gameObject.tag == "terrain") {
			BoatSmash.Play ();
		}
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
			target.gameObject.SetActive (false);
		}
		if (target.gameObject.tag == "trigger-2") {
			BoatControl.inputEnabled = false;
			BoatControl.boatSpeedSet = 0;
			book.SetActive(true);
			Debug.Log("trigger 2 activated");
			textDisp = true;
			canvas.GetComponent<Animator>().SetBool("textDisplay", textDisp);
			dialogue.V1();
			target.gameObject.SetActive (false);
		}
		if (target.gameObject.tag == "trigger-3") {
			BoatControl.inputEnabled = false;
			BoatControl.boatSpeedSet = 0;
			book.SetActive(true);
			Debug.Log("trigger 3 activated");
			textDisp = true;
			canvas.GetComponent<Animator>().SetBool("textDisplay", textDisp);
			dialogue.B1();
			target.gameObject.SetActive (false);
		}
		if (target.gameObject.tag == "trigger-4") {
			BoatControl.inputEnabled = false;
			BoatControl.boatSpeedSet = 0;
			book.SetActive(true);
			Debug.Log("trigger 4 activated");
			textDisp = true;
			canvas.GetComponent<Animator>().SetBool("textDisplay", textDisp);
			dialogue.R1();
			target.gameObject.SetActive (false);
		}
	}
	public void ClosePanel() {
		textDisp = false;
		canvas.GetComponent<Animator>().SetBool("textDisplay", textDisp);
		BoatControl.inputEnabled = true;
		BoatControl.boatSpeedSet = 0;
		activateT4++;
	}

	public void EndGame(){
		GetComponent<SpriteRenderer> ().sprite = flag0;
		transform.position = initialPos;
		transform.eulerAngles = new Vector3 (0.0f, 0.0f, 270.0f);
		textDisp = false;
		canvas.GetComponent<Animator>().SetBool("textDisplay", textDisp);
		startEndTimer = true;
	}
}