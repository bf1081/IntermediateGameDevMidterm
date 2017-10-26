using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	Vector3 inputVector;
	Rigidbody myRigidbody;
	public static float speed;
	public float turnspeed;

	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {

		float horiontalInput = Input.GetAxis ("Horizontal");

		//get "Horizontal" input (A/D, Left/Right)

		float verticalInput = Input.GetAxis ("Vertical");

		//get "Vertical" input (W/S, Up/Down, forward and backward)

		transform.Rotate (0f, horiontalInput * Time.deltaTime * turnspeed, 0f);

		//rotate on the y axis

		inputVector = new Vector3 (0f, 0f, verticalInput);

		//put our input data into our "inputVector"

		if( inputVector.magnitude > 1f) {

			//prevents "faster when moving diagonally
			inputVector = Vector3.Normalize (inputVector);
		}

	}
	//Fixed Update runs when physics runs
	void FixedUpdate () {
		myRigidbody.AddRelativeForce (inputVector * speed);

	}
}
