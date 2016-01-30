using UnityEngine;
using System.Collections;

public class Whirlpool : MonoBehaviour {

	public GameObject InnerWhirlpool;
	public GameObject Boat;
	private bool moveTowards;

	void Update(){
		if (moveTowards) {
			Vector3.MoveTowards (new Vector3 (Boat.transform.position.x, Boat.transform.position.y, Boat.transform.position.z), 
				new Vector3 (InnerWhirlpool.transform.position.x, InnerWhirlpool.transform.position.y, InnerWhirlpool.transform.position.z), 1000 * Time.deltaTime);
			print ("FUCK YEAH");
		}
	}

	void OnTriggerEnter2D(Collider2D collide){
		if (collide.gameObject.tag == "Player") {
			moveTowards = true;
		}
	}
}
