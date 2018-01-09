using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TheWhisper : MonoBehaviour {

	public Transform target;
	public Transform myTransform;
	public GameObject Player;
	public float speed = 50f;
	public Light torchlight;
	public Image Horus;
	public static bool IsWhispered = false;
	public static bool WhisperLives = false;

	//public static int RoomsRemaining = 3;
	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Player");
		//torchlight = GameObject.Find ("Point Lightplayer");
	}
	
	// Update is called once per frame
	void Update () {
		//torchlight = GameObject.Find ("Point Lightplayer");
		target = GameObject.Find ("Player").transform;
		transform.LookAt (target);
		transform.Translate (Vector3.forward * speed * Time.deltaTime);


		if (IsWhispered == true) {
			torchlight.color = Color.blue;
			torchlight.range = 5;
			Horus.enabled = false;
			RenderSettings.reflectionIntensity = 0f;
			Destroy (this.gameObject);
		}

		if (WhisperLives == false) {
			Destroy (this.gameObject);
		}
	}

	void OnCollisionEnter(Collision here) {

		if (here.gameObject.tag == "Player") {
			IsWhispered = true;
			PlayerStats.CurseAmount = PlayerStats.CurseAmount + Random.Range (5, 20);
			//RoomsRemaining = 3;
			Shop.AquiredItem1 = "null";
			Shop.AquiredItem2 = "null";
			Shop.AquiredItem3 = "null";
			torchlight.color = Color.blue;
			torchlight.range = 5;
			Horus.enabled = false;
			RenderSettings.reflectionIntensity = 0f;
			DynamicGI.UpdateEnvironment ();
		

			//Destroy (this.gameObject);

		}

	}
}
