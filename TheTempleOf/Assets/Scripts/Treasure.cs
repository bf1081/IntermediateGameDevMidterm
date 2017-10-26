using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Treasure : MonoBehaviour {
	public GameObject Player;
	//public int GoldToBeGained;
	public Text Cash;
	public AudioClip impact;
	public AudioSource audiosource;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Player");
		Cash = GameObject.Find ("GoldAquired").GetComponent<Text>();
		audiosource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	

	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "Player" && Shop.Ptah == false) {
			PlayerStats.GoldToBeGained = PlayerStats.GoldToBeGained + Random.Range (1, 100);
			//MakeNewRoom.Gold = MakeNewRoom.Gold + Random.Range (1, 100);
			audiosource.Play();
			Destroy (this.gameObject);
			//audiosource.Play();

		}

		if (col.gameObject.tag == "Player" && Shop.Ptah == true) {
			PlayerStats.GoldToBeGained = PlayerStats.GoldToBeGained + Random.Range (100, 250);
			//MakeNewRoom.Gold = MakeNewRoom.Gold + Random.Range (1, 100);
			audiosource.Play();
			Destroy (this.gameObject);
		//	audiosource.Play();
		}
	}
	
}
