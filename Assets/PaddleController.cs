using UnityEngine;
using System.Collections;

public class PaddleController : MonoBehaviour {
	public string upKey;
	public string downKey;
	public float upperBoundary = 4;
	public float lowerBoundary = -4;
	public float speed = 0.2f;

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (upKey))
			transform.Translate (Vector3.up * speed);
		if (Input.GetKey (downKey))
			transform.Translate (Vector3.down * speed);

		checkBoundaries ();
	}

	void checkBoundaries(){
		if (transform.position.y > upperBoundary)
			transform.position = new Vector3(transform.position.x, upperBoundary, 0);
		if(transform.position.y < lowerBoundary)
			transform.position = new Vector3(transform.position.x, lowerBoundary, 0);
	}
}
