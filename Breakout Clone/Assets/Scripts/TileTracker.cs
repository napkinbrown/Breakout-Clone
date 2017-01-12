using UnityEngine;
using System.Collections;

public class TileTracker : MonoBehaviour {

	public PlayerController player;
	private int tilesLeft;

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		tilesLeft = transform.childCount;

		if(tilesLeft == 0)
			player.setCanControl(false);
			print("End game");
	}
}
