using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMachine : MonoBehaviour {

	private float t; 
	private GameObject machine; 

	// Use this for initialization
	void Start () {
		t = 0; 
		machine = GameObject.Find ("BallMachine");
	}
	
	// Update is called once per frame
	void Update () {
		if(t > 4.0) {
			GameObject new_ball = (GameObject)Instantiate (Resources.Load("Ball"));
			new_ball.transform.position = machine.transform.position; 
			Rigidbody rb = new_ball.GetComponent<Rigidbody>();
			rb.AddForce (new Vector3(0f, 0f,100f)); 
			t = 0; 
		}
		t += Time.deltaTime; 
	}
}
