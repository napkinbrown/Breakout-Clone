using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float playerSpeed = 1;
	public Rigidbody rb;

	void Start () {
		rb = GetComponent<Rigidbody>();
	}

	void Update () {
		rb.velocity = new Vector3(Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime,0);
	}

}
