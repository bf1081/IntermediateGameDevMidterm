using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Sobek : MonoBehaviour {
	public string[] Item1;

	public static int costgold;
	public static int costcurse;
	public static int costcurepages;

	public  Text ItemName1;

	public CanvasGroup Shoppe;
	public GameObject ShopRange;
	public GameObject Player;

	public Text costgoldtxt1;
	public Text costcursetxt2;
	public Text costcuretxt3;





	public static bool namechange = true;


	// Use this for initialization
	void Start () {

		Item1 = new string[22];

		Item1 [0] = "Worn Boots";
		Item1 [1] = "Leather Shoes";
		Item1 [2] = "Pace of Thoth";
		Item1 [3] = "Palm Torch";
		Item1 [4] = "Acacia Torch";
		Item1 [5] = "Sycomore Torch";
		Item1 [6] = "Cure Sentence";
		Item1 [7] = "Cure Paragraph";
		Item1 [8] = "Cure Page";
		Item1 [9] = "Healing Tonic";
		Item1 [10] = "Rejuvenation Potion";
		Item1 [11] = "Breath of Life";
		Item1 [12] = "Bronze Armor";
		Item1 [13] = "Iron Armor";
		Item1 [14] = "Might of Osiris";

		Item1 [15] = "Sign of Anubis";
		Item1 [16] = "Sign of Horus";
		Item1 [17] = "Palm Torch";
		Item1 [18] = "Sign of Set";
		Item1 [19] = "Worn Boots";
		Item1 [20] = "Sign of Isis";
		Item1 [21] = "Sign of Ptah";
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.I) && Shoppe.alpha == 1 && MakeNewRoom.Gold >= costgold) {
			MakeNewRoom.Gold = MakeNewRoom.Gold - costgold;
			Shop.AquiredItem1 = ItemName1.text;
			Shoppe.alpha = 0;
			namechange = false;
			DynamicGI.UpdateEnvironment ();
		}

		if (Input.GetKey (KeyCode.O) && Shoppe.alpha == 1 && PlayerStats.CurseAmount + costcurse < 100) {
			PlayerStats.CurseAmount = PlayerStats.CurseAmount + costcurse;
			Shop.AquiredItem1 = ItemName1.text;
			Shoppe.alpha = 0;
			namechange = false;
			DynamicGI.UpdateEnvironment ();
		}
		if (Input.GetKey(KeyCode.P) && Shoppe.alpha == 1 && PlayerStats.CursePagesGathered >= costcurepages) {

			PlayerStats.CursePagesGathered = PlayerStats.CursePagesGathered - costcurepages;
			Shop.AquiredItem1 = ItemName1.text;
			Shoppe.alpha = 0;
			namechange = false;
			DynamicGI.UpdateEnvironment ();
		}
	

	
	}

	void OnTriggerEnter(Collider shopfront) {

		if (Input.GetKey (KeyCode.E) && namechange == true) {
			//Name1.text = Shopnames1 [Random.Range (0, 20)] + " " + "of " + Shopnames2 [Random.Range (0, 41)];
			//	Name2.text = Shopnames2 [Random.Range (0, 39)]
			Shoppe.alpha = 1;
			ItemName1.text = Item1 [Random.Range (0, 22)];
		//	ItemName2.text = Item2 [Random.Range (0, 22)];
		//	ItemName3.text = Item3 [Random.Range (0, 22)];
			costgoldtxt1.text = costgold.ToString ();
			costcursetxt2.text = costcurse.ToString ();
			costcuretxt3.text = costcurepages.ToString ();
			namechange = false;

			//WhichItem1 = ItemName1.text;
		//	WhichItem2 = ItemName2.text;
		//	WhichItem3 = ItemName3.text;
		}

	}

	void OnTriggerExit(Collider shopfront) {
		Shoppe.alpha = 0;

	}
}
