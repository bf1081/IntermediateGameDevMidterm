using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BasicLootCrates : MonoBehaviour {

	public Image myImage;
	public Text thisText;
	public GameObject Crate;
	public static bool isIn = false;
	public AudioSource audios;
	public AudioClip impact;

	// Use this for initialization
	void Start () {
		audios = GetComponent<AudioSource> ();
		myImage = GameObject.Find ("Loadingbar").GetComponent<Image> ();
		thisText = GameObject.Find ("TextLoading").GetComponent<Text> ();
		Crate = GameObject.Find ("WickerBasket");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.E) && isIn == true) {
			myImage.enabled = true;
			thisText.enabled = true;
		}
		if (progress_bar_Cyris_BIIIITHC.Fill_Amount_Cyrus >= 0.99 && isIn == true && Shop.Ptah == false) {
			myImage.enabled = false;
			thisText.enabled = false;
			progress_bar_Cyris_BIIIITHC.Fill_Amount_Cyrus = 0;
			PlayerStats.GoldToBeGained = PlayerStats.GoldToBeGained + Random.Range (50, 300);
			//audios.Play();
			Destroy (this.gameObject);
			Destroy (Crate);
			isIn = false;
		//	audios.Play();
		}
		if (progress_bar_Cyris_BIIIITHC.Fill_Amount_Cyrus >= 0.99 && Shop.Ptah == true && isIn == true) {
			myImage.enabled = false;
			thisText.enabled = false;
			progress_bar_Cyris_BIIIITHC.Fill_Amount_Cyrus = 0;
			PlayerStats.GoldToBeGained = PlayerStats.GoldToBeGained + Random.Range (250, 500);
			//audios.Play();
			Destroy (this.gameObject);
			Destroy (Crate);
			isIn = false;
		//	audios.Play();
		}

	}

	void OnTriggerEnter(Collider circle) {
		if (circle.tag == "Player") {
			isIn = true;
		//	myImage.enabled = true;
		//	thisText.enabled = true;
		}
	}

	void OnTriggerExit (Collider circle) {
		if (circle.tag == "Player") {
			isIn = false;
			myImage.enabled = false;
			thisText.enabled = false;
		}
		}

	}

