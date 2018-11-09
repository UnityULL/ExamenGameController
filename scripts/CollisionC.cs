using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionC : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameController.positionControl += changePosition;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void changePosition(int power){
		Vector3 current = transform.position;
		current.x += power / 2;
		current.z += power / 2;

		transform.position = current;
	}
}
