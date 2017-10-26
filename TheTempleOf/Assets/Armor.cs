using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Armor : MonoBehaviour {

	public Image Armor1;
	public Image Armor2;
	public Image Armor3;


	// Use this for initialization
	void Start () {
		Armor1 = GameObject.Find ("Armor 1").GetComponent<Image>();
		Armor2 = GameObject.Find ("Armor 2").GetComponent<Image>();
		Armor3 = GameObject.Find ("Armor 3").GetComponent<Image>();

	}

	// Update is called once per frame
	void Update () {
		//enemy = GameObject.Find ("Enemy");

	
	}

	void OnTriggerEnter(Collider armor) {
		if (armor.tag == "Enemy" && Armor1.enabled == true && Armor2.enabled == false && Armor3.enabled == false) {
			EnemyFollow.speed = 1.5f;
		}
		if (armor.tag == "Enemy" && Armor1.enabled == true && Armor2.enabled == true && Armor3.enabled == false) {
			EnemyFollow.speed = 1f;
		}
		if (armor.tag == "Enemy" && Armor1.enabled == true && Armor2.enabled == true && Armor3.enabled == true) {
			EnemyFollow.speed = 0.5f;
		}

	}

	void OnTriggerExit(Collider armor) {
		if (armor.tag == "Enemy" && Armor1.enabled == true && Armor2.enabled == false && Armor3.enabled == false) {
			EnemyFollow.speed = 2f;
		}
		if (armor.tag == "Enemy" && Armor1.enabled == true && Armor2.enabled == true && Armor3.enabled == false) {
			EnemyFollow.speed = 2f;
		}
		if (armor.tag == "Enemy" && Armor1.enabled == true && Armor2.enabled == true && Armor3.enabled == true) {
			EnemyFollow.speed = 2f;
		}
	}
}
