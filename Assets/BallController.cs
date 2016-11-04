using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BallController : MonoBehaviour {
	float xspeed, yspeed;
	int scoreLeft = 0;
	int scoreRight = 0;
	public Text scoreLeftText;
	public Text scoreRightText;

	// Use this for initialization
	void Start () {
		scoreLeft = 0;
		scoreRight = 0;
		scoreLeftText.text = "0";
		scoreRightText.text = "0";

		xspeed = randomStartSpeed();
		yspeed = randomStartSpeed ();
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (xspeed, yspeed);
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.name == "RightWall") {
			scoreLeft++;
			scoreLeftText.text = scoreLeft.ToString ();
			transform.position = Vector3.zero;
		}
		if (col.gameObject.name == "LeftWall") {
			scoreRight++;
			scoreRightText.text = scoreRight.ToString ();
			transform.position = Vector3.zero;
		}
	}
	
	float randomStartSpeed(){
		float speed = Random.Range (-5, 4);
		if (speed >= 0) {
			speed = 3f;
		} else
			speed = -3f;

		return speed;
	}
}
