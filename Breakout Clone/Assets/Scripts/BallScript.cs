using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {

	public float minSpeed;
	public float maxSpeed;
	public float initialSpeed;
	private float currentSpeed;
	private bool ballInPlay = false;

	public Rigidbody rb;

	void Start () {
		rb = GetComponent<Rigidbody>();
	}

	void Update () {
		if (Input.GetButtonDown("Fire1") && ballInPlay == false){
            transform.parent = null;
            ballInPlay = true;
            rb.isKinematic = false;
            currentSpeed = initialSpeed;
			rb.AddForce(new Vector3(initialSpeed, initialSpeed, 0));
        }

	}

	/*Used by the Player object to add or subtract speed*/
	public void changeSpeed(float speedDelta){
		currentSpeed += speedDelta;

		if(currentSpeed > maxSpeed) 
			currentSpeed = maxSpeed;
		if(currentSpeed < minSpeed) 
			currentSpeed = minSpeed;
	}
}
