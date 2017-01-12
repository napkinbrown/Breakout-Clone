using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float playerSpeed = 1;
	private bool canControl; //lose control at the end of the game
	public Rigidbody rb;

	void Start () {
		rb = GetComponent<Rigidbody>();
		canControl = true;
	}

	void Update () {
		if(canControl){
			rb.velocity = new Vector3(Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime,0);
		}
	}

	public void setCanControl(bool canControl){
		this.canControl =  canControl;
	}
}
