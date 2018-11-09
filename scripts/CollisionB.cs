using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionB : MonoBehaviour {

	private int power;
	// Use this for initialization
	void Start () {
		power = 0;
		GameController.powerControl += increasePower;
	}
	
	void OnCollisionEnter(Collision collision) {
		print ("My power is " + power);
		GameController.updatePosition (power);
	}

	public void increasePower(){
		power++;
		changeColor ();
	}

	private void changeColor(){
		// Change color random
		Color newColor = new Color( Random.value, Random.value, Random.value, 1.0f );
		gameObject.GetComponent<Renderer>().material.color = newColor;
	}
}
