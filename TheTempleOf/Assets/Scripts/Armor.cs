using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Armor : MonoBehaviour {

	public Image Armor1;
	public Image Armor2;
	public Image Armor3;
	public Image Armor4;
	public static bool isInRange = false;


	// Use this for initialization
	void Start () {
		Armor1 = GameObject.Find ("Armor 1").GetComponent<Image>();
		Armor2 = GameObject.Find ("Armor 2").GetComponent<Image>();
		Armor3 = GameObject.Find ("Armor 3").GetComponent<Image>();
		Armor4 = GameObject.Find ("Armor 4").GetComponent<Image> ();

	}

	// Update is called once per frame
	void Update () {
		//enemy = GameObject.Find ("Enemy");

	
	}

	void OnTriggerEnter(Collider armor) {
		if (armor.tag == "Enemy" && Armor1.enabled == true && Armor2.enabled == false && Armor3.enabled == false && Armor4.enabled == false) {
			EnemyFollow.speed = EnemyFollow.diffspeed - .3f;
			isInRange = true;
		}
		if (armor.tag == "Enemy" && Armor1.enabled == true && Armor2.enabled == true && Armor3.enabled == false && Armor4.enabled == false) {
			EnemyFollow.speed = EnemyFollow.diffspeed - .8f;
			isInRange = true;

		}
		if (armor.tag == "Enemy" && Armor1.enabled == true && Armor2.enabled == true && Armor3.enabled == true && Armor4.enabled == false) {
			EnemyFollow.speed = EnemyFollow.diffspeed - 1.3f;
			isInRange = true;
		}

		if (armor.tag == "Enemy" && Armor1.enabled == true && Armor2.enabled == true && Armor3.enabled == true && Armor4.enabled == true) {
			EnemyFollow.speed = EnemyFollow.diffspeed - 2f;
			isInRange = true;
		}
	

	}

	void OnTriggerExit(Collider armor) {
		if (armor.tag == "Enemy" && Armor1.enabled == true && Armor2.enabled == false && Armor3.enabled == false && Armor4.enabled == false) {
			EnemyFollow.speed = EnemyFollow.diffspeed;
			isInRange = false;
		}
		if (armor.tag == "Enemy" && Armor1.enabled == true && Armor2.enabled == true && Armor3.enabled == false && Armor4.enabled == false) {
			EnemyFollow.speed = EnemyFollow.diffspeed;
			isInRange = false;

		}
		if (armor.tag == "Enemy" && Armor1.enabled == true && Armor2.enabled == true && Armor3.enabled == true && Armor4.enabled == false) {
			EnemyFollow.speed = EnemyFollow.diffspeed;
			isInRange = false;
		}

		if (armor.tag == "Enemy" && Armor1.enabled == true && Armor2.enabled == true && Armor3.enabled == true && Armor4.enabled == true) {
			EnemyFollow.speed = EnemyFollow.diffspeed;
			isInRange = false;
		}
	}
}
