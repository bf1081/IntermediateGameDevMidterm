using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WhichPerk : MonoBehaviour {
	
	public static Text Classname;
	// Use this for initialization
	void Start () {

		Classname = GameObject.Find ("Class Name").GetComponent<Text> ();
	
	}
	
	// Update is called once per frame
	void Update () {


		//Disciple of Sobek
		if (PickAPerk.Perk1 == 0 && PickAPerk2.Perk2 == 0) {
			Classname.text = "WORSHIPER";
		}
		if (PickAPerk.Perk1 == 0 && PickAPerk2.Perk2 == 1) {
			Classname.text = "ESCAPIST";
		}
		if (PickAPerk.Perk1 == 0 && PickAPerk2.Perk2 == 2) {
			Classname.text = "PREACHER";
		}
		if (PickAPerk.Perk1 == 0 && PickAPerk2.Perk2 == 3) {
			Classname.text = "APOSTLE";
		}

		if (PickAPerk.Perk1 == 0 && PickAPerk2.Perk2 == 4) {
			Classname.text = "CULTIST";
		}


		if (PickAPerk.Perk1 == 0 && PickAPerk2.Perk2 == 5) {
			Classname.text = "PRIEST";
		}

		if (PickAPerk.Perk1 == 0 && PickAPerk2.Perk2 == 6) {
			Classname.text = "DEMIGOD";
		}
		if (PickAPerk.Perk1 == 0 && PickAPerk2.Perk2 == 7) {
			Classname.text = "LIGHTSEEKER";
		}

		//Marathon Man

		if (PickAPerk.Perk1 == 1 && PickAPerk2.Perk2 == 0) {
			Classname.text = "ESCAPIST";
		}
		if (PickAPerk.Perk1 == 1 && PickAPerk2.Perk2 == 1) {
			Classname.text = "DASHER";
		}
		if (PickAPerk.Perk1 == 1 && PickAPerk2.Perk2 == 2) {
			Classname.text = "DAREDEVIL";
		}
		if (PickAPerk.Perk1 == 1 && PickAPerk2.Perk2 == 3) {
			Classname.text = "SCOUT";
		}

		if (PickAPerk.Perk1 == 1 && PickAPerk2.Perk2 == 4) {
			Classname.text = "EXPLORER";
		}


		if (PickAPerk.Perk1 == 1 && PickAPerk2.Perk2 == 5) {
			Classname.text = "THIEF";
		}

		if (PickAPerk.Perk1 == 1 && PickAPerk2.Perk2 == 6) {
			Classname.text = "ATHLETE";
		}
		if (PickAPerk.Perk1 == 1 && PickAPerk2.Perk2 == 7) {
			Classname.text = "HUNTER";
		}

		//Curse Denier

		if (PickAPerk.Perk1 == 2 && PickAPerk2.Perk2 == 0) {
			Classname.text = "PREACHER";
		}
		if (PickAPerk.Perk1 == 2 && PickAPerk2.Perk2 == 1) {
			Classname.text = "DAREDEVIL";
		}
		if (PickAPerk.Perk1 == 2 && PickAPerk2.Perk2 == 2) {
			Classname.text = "IMMORTAL";
		}
		if (PickAPerk.Perk1 == 2 && PickAPerk2.Perk2 == 3) {
			Classname.text = "TACTICIAN";
		}

		if (PickAPerk.Perk1 == 2 && PickAPerk2.Perk2 == 4) {
			Classname.text = "WARLOCK";
		}


		if (PickAPerk.Perk1 == 2 && PickAPerk2.Perk2 == 5) {
			Classname.text = "SOULTRADER";
		}

		if (PickAPerk.Perk1 == 2 && PickAPerk2.Perk2 == 6) {
			Classname.text = "POWERHOUSE";
		}
		if (PickAPerk.Perk1 == 2 && PickAPerk2.Perk2 == 7) {
			Classname.text = "HOARDER";
		}
		//Need A Light

		if (PickAPerk.Perk1 == 3 && PickAPerk2.Perk2 == 0) {
			Classname.text = "APOSTLE";
		}
		if (PickAPerk.Perk1 == 3 && PickAPerk2.Perk2 == 1) {
			Classname.text = "SCOUT";
		}
		if (PickAPerk.Perk1 == 3 && PickAPerk2.Perk2 == 2) {
			Classname.text = "TACTICIAN";
		}
		if (PickAPerk.Perk1 == 3 && PickAPerk2.Perk2 == 3) {
			Classname.text = "FIRESTARTER";
		}

		if (PickAPerk.Perk1 == 3 && PickAPerk2.Perk2 == 4) {
			Classname.text = "SEARCHER";
		}


		if (PickAPerk.Perk1 == 3 && PickAPerk2.Perk2 == 5) {
			Classname.text = "ERUDITE";
		}

		if (PickAPerk.Perk1 == 3 && PickAPerk2.Perk2 == 6) {
			Classname.text = "LEADER";
		}
		if (PickAPerk.Perk1 == 3 && PickAPerk2.Perk2 == 7) {
			Classname.text = "SCAVENGER";
		}

		//Close Reading

		if (PickAPerk.Perk1 == 4 && PickAPerk2.Perk2 == 0) {
			Classname.text = "CULTIST";
		}
		if (PickAPerk.Perk1 == 4 && PickAPerk2.Perk2 == 1) {
			Classname.text = "EXPLORER";
		}
		if (PickAPerk.Perk1 == 4 && PickAPerk2.Perk2 == 2) {
			Classname.text = "WARLOCK";
		}
		if (PickAPerk.Perk1 == 4 && PickAPerk2.Perk2 == 3) {
			Classname.text = "SEARCHER";
		}

		if (PickAPerk.Perk1 == 4 && PickAPerk2.Perk2 == 4) {
			Classname.text = "LIBRARIAN";
		}


		if (PickAPerk.Perk1 == 4 && PickAPerk2.Perk2 == 5) {
			Classname.text = "LOOPHOLER";
		}

		if (PickAPerk.Perk1 == 4 && PickAPerk2.Perk2 == 6) {
			Classname.text = "ENGINEER";
		}
		if (PickAPerk.Perk1 == 4 && PickAPerk2.Perk2 == 7) {
			Classname.text = "DECODER";
		}

		//HARD BARGAIN

		if (PickAPerk.Perk1 == 5 && PickAPerk2.Perk2 == 0) {
			Classname.text = "PRIEST";
		}
		if (PickAPerk.Perk1 == 5 && PickAPerk2.Perk2 == 1) {
			Classname.text = "THIEF";
		}
		if (PickAPerk.Perk1 == 5 && PickAPerk2.Perk2 == 2) {
			Classname.text = "SOULTRADER";
		}
		if (PickAPerk.Perk1 == 5 && PickAPerk2.Perk2 == 3) {
			Classname.text = "ERUDITE";
		}

		if (PickAPerk.Perk1 == 5 && PickAPerk2.Perk2 == 4) {
			Classname.text = "LOOPHOLER";
		}


		if (PickAPerk.Perk1 == 5 && PickAPerk2.Perk2 == 5) {
			Classname.text = "ENTREPRENEUR";
		}

		if (PickAPerk.Perk1 == 5 && PickAPerk2.Perk2 == 6) {
			Classname.text = "WARLORD";
		}
		if (PickAPerk.Perk1 == 5 && PickAPerk2.Perk2 == 7) {
			Classname.text = "RAIDER";
		}

		//Intimidator

		if (PickAPerk.Perk1 == 6 && PickAPerk2.Perk2 == 0) {
			Classname.text = "DEMIGOD";
		}
		if (PickAPerk.Perk1 == 6 && PickAPerk2.Perk2 == 1) {
			Classname.text = "ATHLETE";
		}
		if (PickAPerk.Perk1 == 6 && PickAPerk2.Perk2 == 2) {
			Classname.text = "POWERHOUSE";
		}
		if (PickAPerk.Perk1 == 6 && PickAPerk2.Perk2 == 3) {
			Classname.text = "LEADER";
		}

		if (PickAPerk.Perk1 == 6 && PickAPerk2.Perk2 == 4) {
			Classname.text = "ENGINEER";
		}


		if (PickAPerk.Perk1 == 6 && PickAPerk2.Perk2 == 5) {
			Classname.text = "WARLORD";
		}

		if (PickAPerk.Perk1 == 6 && PickAPerk2.Perk2 == 6) {
			Classname.text = "BEASTMASTER";
		}
		if (PickAPerk.Perk1 == 6 && PickAPerk2.Perk2 == 7) {
			Classname.text = "DRIFTER";
		}

		//Collection

		if (PickAPerk.Perk1 == 7 && PickAPerk2.Perk2 == 0) {
			Classname.text = "LIGHTSEEKER";
		}
		if (PickAPerk.Perk1 == 7 && PickAPerk2.Perk2 == 1) {
			Classname.text = "HUNTER";
		}
		if (PickAPerk.Perk1 == 7 && PickAPerk2.Perk2 == 2) {
			Classname.text = "HOARDER";
		}
		if (PickAPerk.Perk1 == 7 && PickAPerk2.Perk2 == 3) {
			Classname.text = "SCAVENGER";
		}

		if (PickAPerk.Perk1 == 7 && PickAPerk2.Perk2 == 4) {
			Classname.text = "DECODER";
		}


		if (PickAPerk.Perk1 == 7 && PickAPerk2.Perk2 == 5) {
			Classname.text = "RAIDER";
		}

		if (PickAPerk.Perk1 == 7 && PickAPerk2.Perk2 == 6) {
			Classname.text = "DRIFTER";
		}
		if (PickAPerk.Perk1 == 7 && PickAPerk2.Perk2 == 7) {
			Classname.text = "GATHERER";
		}




	
	}
}
