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
	public static int ShopPrices = 2000;
	public static bool isIn = false;
	public Image myImage;
	public Text thisText;
	public static bool ShopUIUp = false;
	public Button button1;
	public Button button2;
	public Button button3;
	public Button BuyButton;
	public Button LeaveButton;
	public bool buyone = false;
	public bool buytwo = false;
	public bool buythree = false;
	public ParticleSystem flame;
	public static int keys = 0;
	public static int goldkeys = 0;
	public static bool eclipsekey = false;

	public static bool namechange = true;
	// Use this for initialization
	void Start () {
		torchlight.range = 8f;
		torchlight.color = new Color (1f, 0.698f, 0.2f);;

		Button buy1 = button1.GetComponent<Button> ();
		buy1.onClick.AddListener (PurchaseOne);
		Button buy2 = button2.GetComponent<Button> ();
		buy2.onClick.AddListener (PurchaseTwo);
		Button buy3 = button3.GetComponent<Button> ();
		buy3.onClick.AddListener (PurchaseThree);
		Button buy = BuyButton.GetComponent<Button> ();
		buy.onClick.AddListener (BuyThis);
		Button leave = LeaveButton.GetComponent<Button> ();
		leave.onClick.AddListener (TrynaLeave);
		myImage = GameObject.Find ("LoadingbarShop").GetComponent<Image> ();
		thisText = GameObject.Find ("TextLoadingShop").GetComponent<Text> ();

		if (PickAPerk.Perk1 == 3) {
			torchlight.range = torchlight.range + 1;
		}
		if (PickAPerk2.Perk2 == 3) {
			torchlight.range = torchlight.range + 1;
		}

		if (PickAPerk.Perk1 == 5) {
			ShopPrices = ShopPrices - 100;
		}

		if (PickAPerk2.Perk2 == 5) {
			ShopPrices = ShopPrices - 100;
		}
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

		Item1 = new string[25];

		Item1 [0] = "Swift Pace";
		Item1 [1] = "Rapid Pace";
		Item1 [2] = "Breakneck Pace";
		Item1 [3] = "Palm Torch";
		Item1 [4] = "Acacia Torch";
		Item1 [5] = "Sycomore Torch";
		Item1 [6] = "Cure Sentence";
		Item1 [7] = "Cure Paragraph";
		Item1 [8] = "Cure Page";
		Item1 [9] = "Healing Tonic";
		Item1 [10] = "Rejuvenation Potion";
		Item1 [11] = "Breath of Life";
		Item1 [12] = "Rusted Armor";
		Item1 [13] = "Bronze Armor";
		Item1 [14] = "Iron Armor";
	
		Item1 [15] = "Sign of Anubis";
		Item1 [16] = "Sign of Horus";
		Item1 [17] = "Palm Torch";
		Item1 [18] = "Sign of Set";
		Item1 [19] = "Worn Boots";
		Item1 [20] = "Sign of Isis";
		Item1 [21] = "Sign of Ptah";
		Item1 [22] = "Key";
		Item1 [23] = "Golden Key";
		Item1 [24] = "Eclipse Key";

		Item2 = new string[25];

		Item2 [0] = "Swift Pace";
		Item2 [1] = "Rapid Pace";
		Item2 [2] = "Breakneck Pace";
		Item2 [3] = "Palm Torch";
		Item2 [4] = "Acacia Torch";
		Item2 [5] = "Sycomore Torch";
		Item2 [6] = "Cure Sentence";
		Item2 [7] = "Cure Paragraph";
		Item2 [8] = "Cure Page";
		Item2 [9] = "Healing Tonic";
		Item2 [10] = "Rejuvenation Potion";
		Item2 [11] = "Breath of Life";
		Item2 [12] = "Rusted Armor";
		Item2 [13] = "Bronze Armor";
		Item2 [14] = "Iron Armor";
		Item2 [15] = "Sign of Anubis";
		Item2 [16] = "Sign of Horus";
		Item2 [17] = "Worn Boots";
		Item2 [18] = "Sign of Set";
		Item2 [19] = "Palm Torch";
		Item2 [20] = "Sign of Isis";
		Item2 [21] = "Sign of Ptah";
		Item2 [22] = "Key";
		Item2 [23] = "Golden Key";
		Item2 [24] = "Eclipse Key";


		Item3 = new string[25];

		Item3 [0] = "Swift Pace";
		Item3[1] = "Rapid Pace";
		Item3 [2] = "Breakneck Pace";
		Item3 [3] = "Palm Torch";
		Item3 [4] = "Acacia Torch";
		Item3 [5] = "Sycomore Torch";
		Item3 [6] = "Cure Sentence";
		Item3 [7] = "Cure Paragraph";
		Item3 [8] = "Cure Page";
		Item3 [9] = "Healing Tonic";
		Item3 [10] = "Rejuvenation Potion";
		Item3 [11] = "Breath of Life";
		Item3 [12] = "Rusted Armor";
		Item3 [13] = "Bronze Armor";
		Item3 [14] = "Iron Armor";
		Item3 [15] = "Sign of Anubis";
		Item3 [16] = "Sign of Horus";
		Item3 [17] = "Worn Boots";
		Item3 [18] = "Sign of Set";
		Item3 [19] = "Palm Torch";
		Item3 [20] = "Sign of Isis";
		Item3 [21] = "Sign of Ptah";
		Item3 [22] = "Key";
		Item3 [23] = "Golden Key";
		Item3 [24] = "Eclipse Key";


	}

	void BuyThis () {
		if (buyone == true && Shoppe.alpha == 1 && MakeNewRoom.Gold >= cost1) {
			MakeNewRoom.Gold = MakeNewRoom.Gold - cost1;
			AquiredItem1 = ItemName1.text;
			Shoppe.alpha = 0;
			namechange = false;
			DynamicGI.UpdateEnvironment ();
			ShopUIUp = false;
			isIn = false;

		}

		if (buytwo == true && Shoppe.alpha == 1 && MakeNewRoom.Gold >= cost2) {
			MakeNewRoom.Gold = MakeNewRoom.Gold - cost2;
			AquiredItem2 = ItemName2.text;
			Shoppe.alpha = 0;
			namechange = false;
			DynamicGI.UpdateEnvironment ();
			ShopUIUp = false;
			isIn = false;

		}
		if (buythree == true && Shoppe.alpha == 1 && MakeNewRoom.Gold >= cost3) {

			MakeNewRoom.Gold = MakeNewRoom.Gold - cost3;
			AquiredItem3 = ItemName3.text;
			Shoppe.alpha = 0;
			namechange = false;
			DynamicGI.UpdateEnvironment ();
			ShopUIUp = false;
			isIn = false;
		}
			

		
	}

	void PurchaseOne() {
		buyone = true;
		buytwo = false;
		buythree = false;
		
	}

	void PurchaseTwo() {
		buytwo = true;
		buyone = false;
		buythree = false;
	}

	void PurchaseThree() {
		buythree = true;
		buytwo = false;
		buyone = false;
		
	}

	void TrynaLeave () {

		Shoppe.alpha = 0;
		ShopUIUp = false;
		isIn = false;
		
	}
	
	// Update is called once per frame
	void Update () {

		if (TheWhisper.IsWhispered == true) {
			torchlight.color = Color.blue;
			torchlight.range = 5;
			HorusSign.enabled = false;
			RenderSettings.reflectionIntensity = 0f;
			flame.Stop();
		}
		if (Input.GetKey(KeyCode.E) && isIn == true && BasicLootCrates.isIn == false) {
			myImage.enabled = true;
			thisText.enabled = true;
		}

		if (progress_bar_Cyris_BIIIITHC.Fill_Amount_Cyrus >= 0.99 && isIn == true && namechange == true ) {
			ShopUIUp = true;
			myImage.enabled = false;
			thisText.enabled = false;
			progress_bar_Cyris_BIIIITHC.Fill_Amount_Cyrus = 0;
			Name1.text = Shopnames1 [Random.Range (0, 20)] + " " + "of " + Shopnames2 [Random.Range (0, 41)];
			//	Name2.text = Shopnames2 [Random.Range (0, 39)]
			Shoppe.alpha = 1;
			ItemName1.text = Item1 [Random.Range (0, 25)];
			ItemName2.text = Item2 [Random.Range (0, 25)];
			ItemName3.text = Item3 [Random.Range (0, 25)];
			costxt1.text = cost1.ToString ();
			costxt2.text = cost2.ToString ();
			costxt3.text = cost3.ToString ();
			namechange = false;

			WhichItem1 = ItemName1.text;
			WhichItem2 = ItemName2.text;
			WhichItem3 = ItemName3.text;
		
			//audios.Play();
			isIn = false;
			//	audios.Play();
		}
		

		if (AquiredItem1 == "Key") {
			keys = keys + 1;
		}
		if (AquiredItem2 == "Key") {
			keys = keys + 1;
		}
		if (AquiredItem3 == "Key") {
			keys = keys + 1;
		}

		if (AquiredItem1 == "Golden Key") {
			goldkeys = goldkeys + 1;
		}
		if (AquiredItem2 == "Golden Key") {
			goldkeys = goldkeys + 1;
		}
		if (AquiredItem3 == "Golden Key") {
			goldkeys = goldkeys + 1;
		}

		if (AquiredItem1 == "Eclipse Key") {
			eclipsekey = true;
		}
		if (AquiredItem2 == "Eclipse Key") {
			eclipsekey = true;
		}

		if (AquiredItem3 == "Eclipse Key") {
			eclipsekey = true;
		}
		if (AquiredItem1 == "Swift Pace") {
			OtherPlayerMovement.speed = 5f;
		}
		if (AquiredItem2 == "Swift Pace") {
			OtherPlayerMovement.speed = 5f;
		}
		if (AquiredItem3 == "Swift Pace") {
			OtherPlayerMovement.speed = 5f;
		}
		if ( AquiredItem1 == "Rapid Pace") {
			OtherPlayerMovement.speed = 6f;
		}
		if ( AquiredItem2 == "Rapid Pace") {
			OtherPlayerMovement.speed = 6f;
		}
		if ( AquiredItem3 == "Rapid Pace") {
			OtherPlayerMovement.speed = 6f;
		}

		if (AquiredItem1 == "Breakneck Pace") {
			OtherPlayerMovement.speed = 7f;
		}
		if (AquiredItem2 == "Breakneck Pace") {
			OtherPlayerMovement.speed = 7f;
		}
		if (AquiredItem3 == "Breakneck Pace") {
			OtherPlayerMovement.speed = 7f;
		}

		if (AquiredItem1 == "Pace of Thoth") {
			OtherPlayerMovement.speed = 10f;
		}
		if (AquiredItem2 == "Pace of Thoth") {
			OtherPlayerMovement.speed = 10f;
		}
		if (AquiredItem3 == "Pace of Thoth") {
			OtherPlayerMovement.speed = 10f;
		}

	


		if (AquiredItem1 == "Palm Torch" && TheWhisper.IsWhispered == false) {
			torchlight.range = 15;
			torchlight.color = new Color (1f, 0.698f, 0.2f);
			flame.Play();
		}

		if (AquiredItem2 == "Palm Torch" && TheWhisper.IsWhispered == false) {
			torchlight.range = 15;
			torchlight.color = new Color (1f, 0.698f, 0.2f);
			flame.Play();
}
		if (AquiredItem3 == "Palm Torch" && TheWhisper.IsWhispered == false) {
			torchlight.range = 15;
			torchlight.color = new Color (1f, 0.698f, 0.2f);
			flame.Play();
		}

		if (AquiredItem1 == "Acacia Torch" && TheWhisper.IsWhispered == false) {
			torchlight.range = 20;
			torchlight.color = new Color (1f, 0.698f, 0.2f);
			flame.Play();
		}

		if (AquiredItem2 == "Acacia Torch" && TheWhisper.IsWhispered == false) {
			torchlight.range = 20;
			torchlight.color = new Color (1f, 0.698f, 0.2f);
			flame.Play();
		}

		if (AquiredItem3 == "Acacia Torch" && TheWhisper.IsWhispered == false) {
			torchlight.range = 20;
			torchlight.color = new Color (1f, 0.698f, 0.2f);
			flame.Play();
		}

		if (AquiredItem1 == "Sycomore Torch" && TheWhisper.IsWhispered == false) {
			torchlight.range = 27;
			torchlight.color = new Color (1f, 0.698f, 0.2f);
			flame.Play();
		}

		if (AquiredItem2 == "Sycomore Torch" && TheWhisper.IsWhispered == false) {
			torchlight.range = 27;
			torchlight.color = new Color (1f, 0.698f, 0.2f);
			flame.Play();
		}

		if (AquiredItem3 == "Sycomore Torch" && TheWhisper.IsWhispered == false) {
			torchlight.range = 27;
			torchlight.color = new Color (1f, 0.698f, 0.2f);
			flame.Play();
		}

		if (AquiredItem1 == "Rusted Armor") {
			Armor1.enabled = true;
			Armor2.enabled = false;
			Armor3.enabled = false;
		}
		if (AquiredItem2 == "Rusted Armor") {
			Armor1.enabled = true;
			Armor2.enabled = false;
			Armor3.enabled = false;
		}
		if (AquiredItem3 == "Rusted Armor") {
			Armor1.enabled = true;
			Armor2.enabled = false;
			Armor3.enabled = false;
		}

		if (AquiredItem1 == "Bronze Armor") {
			Armor1.enabled = true;
			Armor2.enabled = true;
			Armor3.enabled = false;
		}

		if (AquiredItem2 == "Bronze Armor") {
			Armor1.enabled = true;
			Armor2.enabled = true;
			Armor3.enabled = false;
		}
		if (AquiredItem3 == "Bronze Armor") {
			Armor1.enabled = true;
			Armor2.enabled = true;
			Armor3.enabled = false;
		}

		if (AquiredItem1 == "Iron Armor") {
			Armor1.enabled = true;
			Armor2.enabled = true;
			Armor3.enabled = true;
		}
		if (AquiredItem2 == "Iron Armor") {
			Armor1.enabled = true;
			Armor2.enabled = true;
			Armor3.enabled = true;
		}

		if (AquiredItem3 == "Iron Armor") {
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
			ShopUIUp = false;
			isIn = false;
		}



		if (Input.GetKey (KeyCode.O) && Shoppe.alpha == 1 && MakeNewRoom.Gold >= cost2) {
			MakeNewRoom.Gold = MakeNewRoom.Gold - cost2;
			AquiredItem2 = ItemName2.text;
			Shoppe.alpha = 0;
			namechange = false;
			DynamicGI.UpdateEnvironment ();
			ShopUIUp = false;
			isIn = false;

		}
		if (Input.GetKey(KeyCode.P) && Shoppe.alpha == 1 && MakeNewRoom.Gold >= cost3) {

			MakeNewRoom.Gold = MakeNewRoom.Gold - cost3;
			AquiredItem3 = ItemName3.text;
			Shoppe.alpha = 0;
			namechange = false;
			DynamicGI.UpdateEnvironment ();
			ShopUIUp = false;
			isIn = false;
		}

	
	}

	void OnTriggerEnter(Collider shopfront) {

//WhichItem1 = ItemName1.text;
//WhichItem2 = ItemName2.text;
//WhichItem3 = ItemName3.text;
		if (shopfront.tag == "Player") {
			isIn = true;
		}
		if (Input.GetKey (KeyCode.E) && namechange == true) {

		}


	}

	void OnTriggerExit(Collider shopfront) {
		Shoppe.alpha = 0;
		ShopUIUp = false;
		isIn = false;
		}



	}

