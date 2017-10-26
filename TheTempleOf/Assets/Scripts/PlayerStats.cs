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


	// Use this for initialization
	void Start () {
		Cash = GameObject.Find ("GoldAquired").GetComponent<Text>();
		Curse = GameObject.Find ("Curse percent").GetComponent<Text> ();
		CurseBook = GameObject.Find ("Curse Book").GetComponent<Text> ();
		TotalCursePages =1000;

	}

	void FixedUpdate () {

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


		Curse.text = "Curse:" + " " + Mathf.Round (CurseAmount).ToString () + "%";
		CurseBook.text = CursePagesGathered.ToString () + " " + "/" + " " + TotalCursePages.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
