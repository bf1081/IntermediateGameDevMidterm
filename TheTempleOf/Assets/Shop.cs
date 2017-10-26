using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Shop : MonoBehaviour {

	public string[] Shopnames1;
	public string[] Shopnames2;
	public string[] Item1;
	public string[] Item2;
	public string[] Item3;
	public static int cost1;
	public static int cost2;
	public static int cost3;
	public Text Name1;
	public  Text ItemName1;
	public  Text ItemName2;
	public  Text ItemName3;
	public CanvasGroup Shoppe;
	public GameObject ShopRange;
	public GameObject Player;
	public Text costxt1;
	public Text costxt2;
	public Text costxt3;
	public static string AquiredItem1;
	public static string AquiredItem2;
	public static string AquiredItem3;
	public Light torchlight;
	public static string WhichItem1;
	public static string WhichItem2;
	public static string WhichItem3;
	public Image Armor1;
	public Image Armor2;
	public Image Armor3;
	public static int lives;
	public static bool Ptah = false;
	public static bool Anubis = false;
	public static bool Isis = false;
	public static bool Set = false;
	public Image AnubisSign;
	public Image SetSign;
	public Image HorusSign;
	public Image PtahSign;
	public Image IsisSign;


	public static bool namechange = true;
	// Use this for initialization
	void Start () {
		Shopnames1 = new string[20];
		Shopnames1 [0] = "Eye";
		Shopnames1 [1] = "Face";
		Shopnames1 [2] = "Tooth";
		Shopnames1 [3] = "Fang";
		Shopnames1 [4] = "Claw";
		Shopnames1 [5] = "Toe";
		Shopnames1 [6] = "Arm";
		Shopnames1 [7] = "Foot";
		Shopnames1 [8] = "Hand";
		Shopnames1 [9] = "Wrist";
		Shopnames1 [10] = "Leg";
		Shopnames1 [11] = "Ear";
		Shopnames1 [12] = "Tongue";
		Shopnames1 [13] = "Brow";
		Shopnames1 [14] = "Heel";
		Shopnames1 [15] = "Voice";
		Shopnames1 [16] = "Mind";
		Shopnames1 [17] = "Mouth";
		Shopnames1 [18] = "Back";
		Shopnames1 [19] = "Spirit";

		Shopnames2 = new string[41];

		Shopnames2 [0] = "Memphis";
		Shopnames2 [1] = "Letopolis";
		Shopnames2 [2] = "Apis";
		Shopnames2 [3] = "Alexandria";
		Shopnames2 [4] = "Rosetta";
		Shopnames2 [5] = "Ptkheka";
		Shopnames2 [6] = "Sais";
		Shopnames2 [7] = "Buto";
		Shopnames2 [8] = "Xois";
		Shopnames2 [9] = "Damanhur";
		Shopnames2 [10] = "Naucratis";
		Shopnames2 [11] = "Heracleion";
		Shopnames2 [12] = "Menouthis";
		Shopnames2 [13] = "Canopus";
		Shopnames2 [14] = "Pithom";
		Shopnames2 [15] = "Busiris";
		Shopnames2 [16] = "Athribis";
		Shopnames2 [17] = "Leontopolis";
		Shopnames2 [18] = "Pharbaetus";
		Shopnames2 [19] = "Sebennytos";
		Shopnames2 [20] = "Heliopolis";
		Shopnames2 [21] = "Sile";
		Shopnames2 [22] = "Pelusium";
		Shopnames2 [23] = "Hermopolis Parva";
		Shopnames2 [24] = "Damietta";
		Shopnames2 [25] = "Mendes";
		Shopnames2 [26] = "Diospolis Inferior";
		Shopnames2 [27] = "Bubastis";
		Shopnames2 [28] = "Tanis";
		Shopnames2 [29] = "Avaris";
		Shopnames2 [30] = "Thebes";
		Shopnames2 [31] = "Naqada";
		Shopnames2 [32] = "Abydos";
		Shopnames2 [33] = "Thinis";
		Shopnames2 [34] = "Asyut";
		Shopnames2 [35] = "Hermopolis Magna";
		Shopnames2 [36] = "Akoris";
		Shopnames2 [37] = "Cynopolis";
		Shopnames2 [38] = "Berenice";
		Shopnames2 [39] = "Quseir";
		Shopnames2 [40] = "Akshay";

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

		Item2 = new string[22];

		Item2 [0] = "Worn Boots";
		Item2 [1] = "Leather Shoes";
		Item2 [2] = "Pace of Thoth";
		Item2 [3] = "Palm Torch";
		Item2 [4] = "Acacia Torch";
		Item2 [5] = "Sycomore Torch";
		Item2 [6] = "Cure Sentence";
		Item2 [7] = "Cure Paragraph";
		Item2 [8] = "Cure Page";
		Item2 [9] = "Healing Tonic";
		Item2 [10] = "Rejuvenation Potion";
		Item2 [11] = "Breath of Life";
		Item2 [12] = "Bronze Armor";
		Item2 [13] = "Iron Armor";
		Item2 [14] = "Might of Osiris";
		Item2 [15] = "Sign of Anubis";
		Item2 [16] = "Sign of Horus";
		Item2 [17] = "Worn Boots";
		Item2 [18] = "Sign of Set";
		Item2 [19] = "Palm Torch";
		Item2 [20] = "Sign of Isis";
		Item2 [21] = "Sign of Ptah";


		Item3 = new string[22];

		Item3 [0] = "Worn Boots";
		Item3[1] = "Leather Shoes";
		Item3 [2] = "Pace of Thoth";
		Item3 [3] = "Palm Torch";
		Item3 [4] = "Acacia Torch";
		Item3 [5] = "Sycomore Torch";
		Item3 [6] = "Cure Sentence";
		Item3 [7] = "Cure Paragraph";
		Item3 [8] = "Cure Page";
		Item3 [9] = "Healing Tonic";
		Item3 [10] = "Rejuvenation Potion";
		Item3 [11] = "Breath of Life";
		Item3 [12] = "Bronze Armor";
		Item3 [13] = "Iron Armor";
		Item3 [14] = "Might of Osiris";
		Item3 [15] = "Sign of Anubis";
		Item3 [16] = "Sign of Horus";
		Item3 [17] = "Worn Boots";
		Item3 [18] = "Sign of Set";
		Item3 [19] = "Palm Torch";
		Item3 [20] = "Sign of Isis";
		Item3 [21] = "Sign of Ptah";


	}
	
	// Update is called once per frame
	void Update () {
		

		if (AquiredItem1 == "Worn Boots") {
			OtherPlayerMovement.speed = 6f;
		}
		if (AquiredItem2 == "Worn Boots") {
			OtherPlayerMovement.speed = 6f;
		}
		if (AquiredItem3 == "Worn Boots") {
			OtherPlayerMovement.speed = 6f;
		}
		if ( AquiredItem1 == "Leather Shoes") {
			OtherPlayerMovement.speed = 7f;
		}
		if ( AquiredItem2 == "Leather Shoes") {
			OtherPlayerMovement.speed = 7f;
		}
		if ( AquiredItem3 == "Leather Shoes") {
			OtherPlayerMovement.speed = 7f;
		}

		if (AquiredItem1 == "Pace of Thoth") {
			OtherPlayerMovement.speed = 9f;
		}
		if (AquiredItem2 == "Pace of Thoth") {
			OtherPlayerMovement.speed = 9f;
		}
		if (AquiredItem3 == "Pace of Thoth") {
			OtherPlayerMovement.speed = 9f;
		}

		if (AquiredItem1 == "Palm Torch") {
			torchlight.range = 17;
		}

		if (AquiredItem2 == "Palm Torch") {
			torchlight.range = 17;
		}
		if (AquiredItem3 == "Palm Torch") {
			torchlight.range = 17;
		}

		if (AquiredItem1 == "Acacia Torch") {
			torchlight.range = 20;
		}

		if (AquiredItem2 == "Acacia Torch") {
			torchlight.range = 20;
		}

		if (AquiredItem3 == "Acacia Torch") {
			torchlight.range = 20;
		}

		if (AquiredItem1 == "Sycomore Torch") {
			torchlight.range = 27;
		}

		if (AquiredItem2 == "Sycomore Torch") {
			torchlight.range = 27;
		}

		if (AquiredItem3 == "Sycomore Torch") {
			torchlight.range = 27;
		}

		if (AquiredItem1 == "Bronze Armor") {
			Armor1.enabled = true;
			Armor2.enabled = false;
			Armor3.enabled = false;
		}
		if (AquiredItem2 == "Bronze Armor") {
			Armor1.enabled = true;
			Armor2.enabled = false;
			Armor3.enabled = false;
		}
		if (AquiredItem3 == "Bronze Armor") {
			Armor1.enabled = true;
			Armor2.enabled = false;
			Armor3.enabled = false;
		}

		if (AquiredItem1 == "Iron Armor") {
			Armor1.enabled = true;
			Armor2.enabled = true;
			Armor3.enabled = false;
		}

		if (AquiredItem2 == "Iron Armor") {
			Armor1.enabled = true;
			Armor2.enabled = true;
			Armor3.enabled = false;
		}
		if (AquiredItem3 == "Iron Armor") {
			Armor1.enabled = true;
			Armor2.enabled = true;
			Armor3.enabled = false;
		}

		if (AquiredItem1 == "Might of Osiris") {
			Armor1.enabled = true;
			Armor2.enabled = true;
			Armor3.enabled = true;
		}
		if (AquiredItem2 == "Might of Osiris") {
			Armor1.enabled = true;
			Armor2.enabled = true;
			Armor3.enabled = true;
		}

		if (AquiredItem3 == "Might of Osiris") {
			Armor1.enabled = true;
			Armor2.enabled = true;
			Armor3.enabled = true;
		}

		if (AquiredItem1 == "Sign of Horus") {
			RenderSettings.reflectionIntensity = 0.5F;
			HorusSign.enabled = true;
		}
		if (AquiredItem2 == "Sign of Horus") {
			RenderSettings.reflectionIntensity = 0.5F;
			HorusSign.enabled = true;
		}
		if (AquiredItem3 == "Sign of Horus") {
			RenderSettings.reflectionIntensity = 0.5F;
			HorusSign.enabled = true;
		}

		if (AquiredItem1 == "Sign of Ptah") {
			Ptah = true;
			PtahSign.enabled = true;
		}
		if (AquiredItem2 == "Sign of Ptah") {
			Ptah = true;
			PtahSign.enabled = true;
		}
		if (AquiredItem3 == "Sign of Ptah") {
			Ptah = true;
			PtahSign.enabled = true;
		}

		if (AquiredItem1 == "Sign of Anubis") {
			Anubis = true;
			AnubisSign.enabled = true;
		}
		if (AquiredItem2 == "Sign of Anubis") {
			Anubis = true;
			AnubisSign.enabled = true;
		}
		if (AquiredItem3 == "Sign of Anubis") {
			Anubis = true;
			AnubisSign.enabled = true;
		}

		if (Anubis == false) {
			AnubisSign.enabled = false;
		}

		if (AquiredItem1 == "Healing Tonic") {
			PlayerStats.CurseAmount = PlayerStats.CurseAmount - Random.Range (5, 15);
			AquiredItem1 = "null";
		}

		if (AquiredItem2 == "Healing Tonic") {
			PlayerStats.CurseAmount = PlayerStats.CurseAmount - Random.Range (5, 15);
			AquiredItem2 = "null";
		}
		if (AquiredItem3 == "Healing Tonic") {
			PlayerStats.CurseAmount = PlayerStats.CurseAmount - Random.Range (5, 15);
			AquiredItem3 = "null";
		}

		if (AquiredItem1 == "Rejuvenation Potion") {
			PlayerStats.CurseAmount = PlayerStats.CurseAmount - Random.Range (10, 35);
			AquiredItem1 = "null";
		}
		if (AquiredItem2 == "Rejuvenation Potion") {
			PlayerStats.CurseAmount = PlayerStats.CurseAmount - Random.Range (10, 35);
			AquiredItem2 = "null";
		}

		if (AquiredItem3 == "Rejuvenation Potion") {
			PlayerStats.CurseAmount = PlayerStats.CurseAmount - Random.Range (10, 35);
			AquiredItem3 = "null";
		}

		if (AquiredItem1 == "Breath of Life") {
			PlayerStats.CurseAmount = PlayerStats.CurseAmount - Random.Range (20, 55);
			AquiredItem1 = "null";
		}
		if (AquiredItem2 == "Breath of Life") {
			PlayerStats.CurseAmount = PlayerStats.CurseAmount - Random.Range (20, 55);
			AquiredItem2 = "null";
		}
		if (AquiredItem3 == "Breath of Life") {
			PlayerStats.CurseAmount = PlayerStats.CurseAmount - Random.Range (20, 55);
			AquiredItem3 = "null";
		}

		if (AquiredItem1 == "Sign of Isis") {
			Isis = true;
			IsisSign.enabled = true;
		}
		if (AquiredItem2 == "Sign of Isis") {
			Isis = true;
			IsisSign.enabled = true;
		}
		if (AquiredItem3 == "Sign of Isis") {
			Isis = true;
			IsisSign.enabled = true;
		}

		if (AquiredItem1 == "Cure Sentence") {
			PlayerStats.CursePagesGathered = PlayerStats.CursePagesGathered + Random.Range (3, 15);
			AquiredItem1 = "null";
		}

		if (AquiredItem2 == "Cure Sentence") {
			PlayerStats.CursePagesGathered = PlayerStats.CursePagesGathered + Random.Range (3, 15);
			AquiredItem2 = "null";
		}
		if (AquiredItem3 == "Cure Sentence") {
			PlayerStats.CursePagesGathered = PlayerStats.CursePagesGathered + Random.Range (3, 15);
			AquiredItem3 = "null";
		}
		if (AquiredItem1 == "Cure Paragraph") {
			PlayerStats.CursePagesGathered = PlayerStats.CursePagesGathered + Random.Range (20, 100);
			AquiredItem1 = "null";
		}
		if (AquiredItem2 == "Cure Paragraph") {
			PlayerStats.CursePagesGathered = PlayerStats.CursePagesGathered + Random.Range (20, 100);
			AquiredItem2 = "null";
		}
		if (AquiredItem3 == "Cure Paragraph") {
			PlayerStats.CursePagesGathered = PlayerStats.CursePagesGathered + Random.Range (20, 100);
			AquiredItem3 = "null";
		}

		if (AquiredItem1 == "Cure Page") {
			PlayerStats.CursePagesGathered = PlayerStats.CursePagesGathered + Random.Range (100, 300);
			AquiredItem1 = "null";
		}
		if (AquiredItem2 == "Cure Page") {
			PlayerStats.CursePagesGathered = PlayerStats.CursePagesGathered + Random.Range (100, 300);
			AquiredItem2 = "null";
		}
		if (AquiredItem3 == "Cure Page") {
			PlayerStats.CursePagesGathered = PlayerStats.CursePagesGathered + Random.Range (100, 300);
			AquiredItem3 = "null";
		}

		if (AquiredItem1 == "Sign of Set") {
			Set = true;
			SetSign.enabled = true;
		}

		if (AquiredItem2 == "Sign of Set") {
			Set = true;
			SetSign.enabled = true;
		}
		if (AquiredItem3 == "Sign of Set") {
			Set = true;
			SetSign.enabled = true;
		}

	

		if (Input.GetKey (KeyCode.I) && Shoppe.alpha == 1 && MakeNewRoom.Gold >= cost1) {
			MakeNewRoom.Gold = MakeNewRoom.Gold - cost1;
			AquiredItem1 = ItemName1.text;
			Shoppe.alpha = 0;
			namechange = false;
			DynamicGI.UpdateEnvironment ();
		}

		if (Input.GetKey (KeyCode.O) && Shoppe.alpha == 1 && MakeNewRoom.Gold >= cost2) {
			MakeNewRoom.Gold = MakeNewRoom.Gold - cost2;
			AquiredItem2 = ItemName2.text;
			Shoppe.alpha = 0;
			namechange = false;
			DynamicGI.UpdateEnvironment ();
		}
		if (Input.GetKey(KeyCode.P) && Shoppe.alpha == 1 && MakeNewRoom.Gold >= cost3) {

			MakeNewRoom.Gold = MakeNewRoom.Gold - cost3;
			AquiredItem3 = ItemName3.text;
			Shoppe.alpha = 0;
			namechange = false;
			DynamicGI.UpdateEnvironment ();
		}

	
	}

	void OnTriggerEnter(Collider shopfront) {

//WhichItem1 = ItemName1.text;
//WhichItem2 = ItemName2.text;
//WhichItem3 = ItemName3.text;

		if (Input.GetKey (KeyCode.E) && namechange == true) {
			Name1.text = Shopnames1 [Random.Range (0, 20)] + " " + "of " + Shopnames2 [Random.Range (0, 41)];
//	Name2.text = Shopnames2 [Random.Range (0, 39)]
			Shoppe.alpha = 1;
			ItemName1.text = Item1 [Random.Range (0, 22)];
			ItemName2.text = Item2 [Random.Range (0, 22)];
			ItemName3.text = Item3 [Random.Range (0, 22)];
			costxt1.text = cost1.ToString ();
			costxt2.text = cost2.ToString ();
			costxt3.text = cost3.ToString ();
			namechange = false;

			WhichItem1 = ItemName1.text;
			WhichItem2 = ItemName2.text;
			WhichItem3 = ItemName3.text;
		}


	}

	void OnTriggerExit(Collider shopfront) {
		Shoppe.alpha = 0;

		}



	}

