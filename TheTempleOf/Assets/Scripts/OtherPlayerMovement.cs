using UnityEngine;
using System.Collections;

public class OtherPlayerMovement : MonoBehaviour {

	Rigidbody rbody;
	Vector3 inputVector;

	public static float speed = 8f;
	public float gravityStrength = 0.1f;
	public static float distance;
	public Transform target;
	public static bool beginning = false;
	public GameObject wall1;
	public GameObject wall2;
	public AudioClip goldget;
	public AudioClip circleget;
	public AudioSource audiosource;

	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody> ();
		audiosource = GetComponent<AudioSource> ();

	}

	// Update is called once per frame
	void Update () {

		if (progress_bar_Cyris_BIIIITHC.Fill_Amount_Cyrus >= 0.99 && BasicLootCrates.isIn == true) {
			audiosource.PlayOneShot (goldget, 0.7F);
			//progress_bar_Cyris_BIIIITHC.Fill_Amount_Cyrus = 0;
		}
		if (progress_bar_Cyris_BIIIITHC.Fill_Amount_Cyrus >= 0.99 && Shop.Ptah == true && BasicLootCrates.isIn == true) {
			audiosource.PlayOneShot (goldget, 0.7F);
		//	progress_bar_Cyris_BIIIITHC.Fill_Amount_Cyrus = 0;
		}

		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");

		inputVector = transform.right * horizontal + transform.forward * vertical;

		if (inputVector.magnitude > 1f) {
			inputVector = Vector3.Normalize (inputVector);
		}

		distance = Vector3.Distance (transform.position, target.position)  / 100f ;

		if (beginning == true) {
			RenderSettings.ambientIntensity = distance;
			RenderSettings.reflectionIntensity = distance / 10f;
		//DynamicGI.UpdateEnvironment ();

		}

	}

	void FixedUpdate () {
		//do this if we aren't pressing anything
		if (inputVector.magnitude > 0.01f) { // thats what this does
			rbody.velocity = inputVector * speed + Physics.gravity * gravityStrength; // always apply gravity
		}
	}
	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "Treasure") {
			audiosource.PlayOneShot (circleget, 0.7F);
		}
		if (col.gameObject.tag == "Treasure" && Shop.Ptah == true) {
			audiosource.PlayOneShot (circleget, 0.7F);
		}

	}



	}
