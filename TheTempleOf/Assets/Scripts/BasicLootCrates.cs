using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BasicLootCrates : MonoBehaviour {

	public Image myImage;
	public Text thisText;
	public Image myImage2;
	public Text myText2;
	public GameObject Crate;
	public static bool isIn = false;
	public AudioSource audios;
	public AudioClip impact;
	public int maxGold;
	public static bool isWooden = false;
	public bool WoodCrate;
	public int isGetable = 2;
	public int CommonLootGoldGet = 0;
	public GameObject Player;
	GameObject[] Vases;
	// Use this for initialization
	void Start () {
		if(PickAPerk.Perk1 == 7) {
			maxGold = maxGold + 50;
		}

		if(PickAPerk2.Perk2 == 7) {
			maxGold = maxGold + 50;
		}
		audios = GetComponent<AudioSource> ();
		Player = GameObject.Find("Player");
		myImage = GameObject.Find ("Loadingbar").GetComponent<Image> ();
		thisText = GameObject.Find ("TextLoading").GetComponent<Text> ();
		myImage2 = GameObject.Find ("LoadingbarCommon").GetComponent<Image> ();
		myText2 = GameObject.Find ("TextLoadingCommon").GetComponent<Text> ();
		Crate = GameObject.Find ("WickerBasket");
	}
	
	// Update is called once per frame
	void Update () {

		CommonLootGoldGet = Random.Range (0,5);

		//if (WoodCrate == true) {
		//	isWooden = true;
		//}
		Vases = GameObject.FindGameObjectsWithTag ("Vase");
		GameObject Closest = null;
		float distance = Mathf.Infinity;
		Vector3 PlayerPosition = Player.transform.position;
		foreach (GameObject Vase in Vases) {
			Vector3 Difference = Vase.transform.position - PlayerPosition;
			float Currdistance = Difference.sqrMagnitude;
			if (Currdistance < distance) {
				Closest = Vase;
				distance = Currdistance;
			}
		}

		if (Closest.name == "WoodenCrate(Clone)") {
			isWooden = true;
			isGetable = Random.Range (0, 3);
		}
		if (Closest.name == "WickerBasket(Clone)") {
			isWooden = true;
			isGetable = Random.Range (0, 3);
		}
		if (Closest.name == "ActualBasket(Clone)") {
			isWooden = true;
			isGetable = Random.Range (0, 3);
		}
		if (Closest.name != "WoodenCrate(Clone)" && Closest.name != "WickerBasket(Clone)" && Closest.name != "ActualBasket(Clone)") {
			isWooden = false;
			isGetable = 2;
		}



		if (Input.GetKey(KeyCode.E) && isIn == true && isWooden == false) {
			myImage.enabled = true;
			thisText.enabled = true;
		}

		if (Input.GetKey(KeyCode.E) && isIn == true && isWooden == true) {
			myImage2.enabled = true;
			myText2.enabled = true;
		}
		if (progress_bar_Cyris_BIIIITHC.Fill_Amount_Cyrus >= 0.99 && isIn == true && Shop.Ptah == false && isGetable == 2 && isWooden == false ) {
			myImage.enabled = false;
			thisText.enabled = false;
			myImage2.enabled = false;
			myText2.enabled = false;
			progress_bar_Cyris_BIIIITHC.Fill_Amount_Cyrus = 0;
			PlayerStats.GoldToBeGained = PlayerStats.GoldToBeGained + Random.Range (100, maxGold);
			//audios.Play();
			Destroy (Closest);
			Destroy (Closest);
			isIn = false;
		//	audios.Play();
		}


		if (progress_bar_Cyris_BIIIITHC.Fill_Amount_Cyrus >= 0.99 && Shop.Ptah == true && isIn == true && isGetable == 2 && isWooden == false) {
			myImage.enabled = false;
			thisText.enabled = false;
			myImage2.enabled = false;
			myText2.enabled = false;
			progress_bar_Cyris_BIIIITHC.Fill_Amount_Cyrus = 0;
			PlayerStats.GoldToBeGained = PlayerStats.GoldToBeGained + Random.Range (250, maxGold + 200);
			//audios.Play();
			Destroy (Closest);
			Destroy (Closest);
			isIn = false;
		//	audios.Play();
		}


		if (progress_bar_Cyris_BIIIITHC.Fill_Amount_Cyrus >= 0.99 && isIn == true && Shop.Ptah == false && isGetable != 2 && isGetable != 3 && isWooden == true ) {
			myImage.enabled = false;
			thisText.enabled = false;
			myImage2.enabled = false;
			myText2.enabled = false;
			progress_bar_Cyris_BIIIITHC.Fill_Amount_Cyrus = 0;
			PlayerStats.GoldToBeGained = PlayerStats.GoldToBeGained + Random.Range (15, 50);
			//audios.Play();
			Destroy (Closest);
			Destroy (Closest);
			isIn = false;
			//	audios.Play();
		}


		if (progress_bar_Cyris_BIIIITHC.Fill_Amount_Cyrus >= 0.99 && Shop.Ptah == true && isIn == true && isGetable != 2 && isWooden == true) {
			myImage.enabled = false;
			thisText.enabled = false;
			myImage2.enabled = false;
			myText2.enabled = false;
			progress_bar_Cyris_BIIIITHC.Fill_Amount_Cyrus = 0;
			PlayerStats.GoldToBeGained = PlayerStats.GoldToBeGained + Random.Range (35, 100);
			//audios.Play();
			Destroy (Closest);
			Destroy (Closest);
			isIn = false;
			//	audios.Play();
		}


		if (progress_bar_Cyris_BIIIITHC.Fill_Amount_Cyrus >= 0.99 && isIn == true && Shop.Ptah == false && isGetable == 2 && isWooden == true ) {
			myImage.enabled = false;
			thisText.enabled = false;
			myImage2.enabled = false;
			myText2.enabled = false;
			progress_bar_Cyris_BIIIITHC.Fill_Amount_Cyrus = 0;

			//audios.Play();
			Destroy (Closest);
			Destroy (Closest);
			isIn = false;
			//	audios.Play();
		}


		if (progress_bar_Cyris_BIIIITHC.Fill_Amount_Cyrus >= 0.99 && Shop.Ptah == true && isIn == true && isGetable == 2 && isWooden == true) {
			myImage.enabled = false;
			thisText.enabled = false;
			myImage2.enabled = false;
			myText2.enabled = false;
			progress_bar_Cyris_BIIIITHC.Fill_Amount_Cyrus = 0;

			//audios.Play();
			Destroy (Closest);
			Destroy (Closest);
			isIn = false;
			//	audios.Play();
		}

		if (progress_bar_Cyris_BIIIITHC.Fill_Amount_Cyrus >= 0.99 && isIn == true && Shop.Ptah == false && isGetable == 3 && isWooden == true ) {
			myImage.enabled = false;
			thisText.enabled = false;
			myImage2.enabled = false;
			myText2.enabled = false;
			progress_bar_Cyris_BIIIITHC.Fill_Amount_Cyrus = 0;

			//audios.Play();
			Destroy (Closest);
			Destroy (Closest);
			isIn = false;
			//	audios.Play();
		}


		if (progress_bar_Cyris_BIIIITHC.Fill_Amount_Cyrus >= 0.99 && Shop.Ptah == true && isIn == true && isGetable == 3 && isWooden == true) {
			myImage.enabled = false;
			thisText.enabled = false;
			myImage2.enabled = false;
			myText2.enabled = false;
			progress_bar_Cyris_BIIIITHC.Fill_Amount_Cyrus = 0;

			//audios.Play();
			Destroy (Closest);
			Destroy (Closest);
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

		if (circle.tag == "Player" && Crate.name == "WoodenCrate") {
		//	isWooden = true;
			//	myImage.enabled = true;
			//	thisText.enabled = true;
		}

		if (circle.tag == "Player" && Crate.name != "WoodenCrate") {
		//	isWooden = false;
			//	myImage.enabled = true;
			//	thisText.enabled = true;
		}
	}

	void OnTriggerExit (Collider circle) {
		if (circle.tag == "Player") {
			isIn = false;
			myImage.enabled = false;
			thisText.enabled = false;
			myImage2.enabled = false;
			myText2.enabled = false;
		}
		}

	}

