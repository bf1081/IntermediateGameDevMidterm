using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour {
	public Text Cash;
	public static int GoldToBeGained;
	public Text Curse;
	public static float CurseAmount;
	public Text CurseBook;
	public static int CursePagesGathered;
	public static int TotalCursePages;
	public Text classname;
	public CanvasGroup GameOver;
	public GameObject Player;
	public float TotalCurseAmount = 100F;
	public CanvasGroup GUI;
	GameObject[] Vases;
	GameObject[] Crates;


	// Use this for initialization
	void Start () {
		if (PickAPerk.Perk1 == 0) {
			MakeNewRoom.RoomTotal = MakeNewRoom.RoomTotal + 1;
		}

		if (PickAPerk2.Perk2 == 0) {
			MakeNewRoom.RoomTotal = MakeNewRoom.RoomTotal + 1;
		}
 		GameOver = GameObject.Find ("GameoverCanvas").GetComponent<CanvasGroup>();
		Player = GameObject.Find ("Player");
		Cash = GameObject.Find ("GoldAquired").GetComponent<Text>();
		Curse = GameObject.Find ("Curse percent").GetComponent<Text> ();
		CurseBook = GameObject.Find ("Curse Book").GetComponent<Text> ();
		TotalCursePages = 1000;

		if (PickAPerk.Perk1 == 4) {
			TotalCursePages = TotalCursePages - 100;
		}

		if (PickAPerk2.Perk2 == 4) {
			TotalCursePages = TotalCursePages - 100;
		}
		classname = GameObject.Find ("Class Name").GetComponent<Text> ();
		if (PickAPerk.Perk1 == 2) {
			TotalCurseAmount = TotalCurseAmount + 10f;
		}
		if (PickAPerk2.Perk2 == 2) {
			TotalCurseAmount = TotalCurseAmount + 10f;
		}

	}

	void FixedUpdate () {


	//	if (Input.GetKey (KeyCode.E) && GUI.alpha < 1.01f) {
	//		GUI.alpha = GUI.alpha + 0.05f;
	//	}
	//	else {
	//		GUI.alpha = GUI.alpha - 0.05f;
	//	}

		classname.text = WhichPerk.Classname.text;

		if (GoldToBeGained > 0) {
			GoldToBeGained = GoldToBeGained - 1;
			MakeNewRoom.Gold = MakeNewRoom.Gold + 1;
			Cash.color =  Color.white;
		}
		if (GoldToBeGained == 0) {
			Cash.color = Color.yellow;
		}
		if (Shop.Isis == true) {
			CurseAmount = CurseAmount + 0.001f;

		}

		if (Shop.Isis == false && EndingofBeginning.CurseOn == true) {
			CurseAmount = CurseAmount + 0.003f;

		}

		if (CursePagesGathered >= TotalCursePages) {
			Destroy (Curse);
			CurseAmount = 0f;
		}

		if (CursePagesGathered > 1000) {
			CursePagesGathered = 1000;
		}


		Curse.text = Mathf.Round (CurseAmount).ToString () + "%";
		CurseBook.text = CursePagesGathered.ToString () + " " + "/" + " " + TotalCursePages.ToString ();
	}
	
	// Update is called once per frame
	void Update () {


	

		if (CurseAmount >= TotalCurseAmount) {
			GameOver.alpha = 1;
			Destroy (Player);
		}
	
	}
}
