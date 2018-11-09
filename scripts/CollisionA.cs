using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // For sliders

public class CollisionA : MonoBehaviour {

	void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Ethan")
		    GameController.updatePower ();
	}
		
}
