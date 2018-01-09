using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyFollow : MonoBehaviour {
	public CanvasGroup GameOver;
	public Transform target;
	public Transform myTransform;
	public GameObject Player;
	public Image Armor1;
	public Image Armor2;
	public Image Armor3;
	public static float speed = 2;
	public static float diffspeed = 2;
	public Rigidbody PlayerBody;
	public GameObject NightHunter;
	// Use this for initialization
	void Start (){
		GameOver.alpha = 0;
		Player = GameObject.Find ("Player");
		GameOver = GameObject.Find ("GameoverCanvas").GetComponent<CanvasGroup>();
		Armor1 = GameObject.Find ("Armor 1").GetComponent<Image> ();
		Armor2 = GameObject.Find ("Armor 2").GetComponent<Image> ();
		Armor3 = GameObject.Find ("Armor 3").GetComponent<Image> ();
		PlayerBody = GameObject.Find ("Player").GetComponent<Rigidbody> ();
		NightHunter = GameObject.Find ("NightHunter");
		if (PickAPerk.Perk1 == 6) {
			speed = diffspeed - .2f;

		}

		if (PickAPerk2.Perk2 == 6) {
			speed = diffspeed - .2f;

		}

	}
	
	// Update is called once per frame
	void Update () {



		if (Armor.isInRange == false) {
		speed = diffspeed;
		}

		if (PickAPerk.Perk1 == 6 && Armor.isInRange == false) {
			speed = diffspeed - .2f;

		}

		if (PickAPerk2.Perk2 == 6 && Armor.isInRange == false) {
			speed = diffspeed - .2f;

		}

		target = GameObject.Find ("Player").transform;
		transform.LookAt (target);
		transform.Translate (Vector3.forward * speed * Time.deltaTime);

	//	if (gameObject.name == "NightHunter") {
	//		speed = 5;
	//	}
	

	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "Player" && Shop.lives == 0 && Shop.Anubis == false) {
			GameOver.alpha = 1;
			Destroy (Player);

		}
		if (col.gameObject.tag == "Player"  && Shop.Anubis == true) {
			//Destroy (this.gameObject);
			Player.transform.position = new Vector3 (-986, 1, -23);
			Player.transform.eulerAngles = new Vector3 (0, 0, 0);
			Shop.AquiredItem1 = "null";
			Shop.AquiredItem2 = "null";
			Shop.AquiredItem3 = "null";
			Shop.Anubis = false;

		}



		if (col.gameObject.tag == "Player" && Shop.lives == 1) {
			//GameOver.alpha = 1;
			Shop.lives = 0;
			Shop.AquiredItem1 = "null";
			Shop.AquiredItem2 = "null";
			Shop.AquiredItem3 = "null";
			PlayerBody.AddRelativeForce (100,100,100);

		}
		if (col.gameObject.tag == "Player" && Shop.lives == 2) {
			//GameOver.alpha = 1;
			Shop.lives = 1;
			Shop.AquiredItem1 = "Bronze Armor";
			Shop.AquiredItem2 = "Bronze Armor";
			Shop.AquiredItem3 = "Bronze Armor";
			PlayerBody.AddRelativeForce (100,100,100);

		}
		if (col.gameObject.tag == "Player" && Shop.lives == 3) {
			//GameOver.alpha = 1;
			Shop.lives = 2;
			Shop.AquiredItem1 = "Iron Armor";
			Shop.AquiredItem2 = "Iron Armor";
			Shop.AquiredItem3 = "Iron Armor";
			PlayerBody.AddRelativeForce (100,100,100);

		}
	}
}
