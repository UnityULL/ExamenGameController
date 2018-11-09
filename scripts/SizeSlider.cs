using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SizeSlider : MonoBehaviour {

	private Slider slider;
	// Use this for initialization
	void Start () {
		slider = GameObject.FindGameObjectWithTag ("Slider").GetComponent<Slider> ();
		slider.onValueChanged.AddListener (delegate {changeSize (); });
	}

	public void changeSize(){
		Rigidbody rd = GetComponent<Rigidbody> ();
		rd.mass = rd.mass * slider.value;
	}

}
