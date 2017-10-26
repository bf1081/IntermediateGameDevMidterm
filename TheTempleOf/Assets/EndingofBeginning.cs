using UnityEngine;
using System.Collections;

public class EndingofBeginning : MonoBehaviour {

	public static bool CurseOn = false;
	public CanvasGroup UI;
	public AudioSource noise;

	// Use this for initialization
	void Start () {

		noise = GameObject.Find ("Player").GetComponent<AudioSource> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider player) {
		OtherPlayerMovement.beginning = false;
		RenderSettings.ambientIntensity = 0f;
		RenderSettings.reflectionIntensity = 0f;
		DynamicGI.UpdateEnvironment ();
		CurseOn = true;
		UI.alpha = 1f;
		noise.enabled = true;

		OtherPlayerMovement.speed = 5f;
	}
}
