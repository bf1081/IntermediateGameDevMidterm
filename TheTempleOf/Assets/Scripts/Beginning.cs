using UnityEngine;
using System.Collections;

public class Beginning : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider start) {
		OtherPlayerMovement.beginning = true;
		DynamicGI.UpdateEnvironment ();

	}
}
