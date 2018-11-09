using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public delegate void powerManager ();
	public static event powerManager powerControl;

	public delegate void positionManager (int power);
	public static event positionManager positionControl;

	// Singleton pattern
	public static GameController instance;

	// Use this for initialization
	void Awake () {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {// If it's not this, destroy it
			Destroy(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void updatePower(){
		if (powerControl != null) 
			powerControl ();
	}

	public static void updatePosition(int power){
		if (positionControl != null) 
			positionControl (power);
	}
}
