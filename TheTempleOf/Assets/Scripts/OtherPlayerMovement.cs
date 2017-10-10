using UnityEngine;
using System.Collections;

public class OtherPlayerMovement : MonoBehaviour {

	Rigidbody rbody;
	Vector3 inputVector;

	public float speed = 5f;
	public float gravityStrength = 0.1f;
	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody> ();

	}

	// Update is called once per frame
	void Update () {

		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");

		inputVector = transform.right * horizontal + transform.forward * vertical;

		if (inputVector.magnitude > 1f) {
			inputVector = Vector3.Normalize (inputVector);
		}

	}

	void FixedUpdate () {
		//do this if we aren't pressing anything
		if (inputVector.magnitude > 0.01f) { // thats what this does
			rbody.velocity = inputVector * speed + Physics.gravity * gravityStrength; // always apply gravity
		}
	}

	}
