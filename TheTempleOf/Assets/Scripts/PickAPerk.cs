using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PickAPerk : MonoBehaviour, IPointerEnterHandler {

	public Text ClassName;
	public Text PerkName;
	//Ray ray;
	//RaycastHit hit;
	public string Perk;
	public Button myButton;

	public static int Perk1;
	public static int Perk2;
	public static int RandomPerk;
	public Color PerkColor;
	public Text PerkName2;


	// Use this for initialization
	void Start () {
		Button btn = myButton.GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);
		RandomPerk = Random.Range (0, 8);
		//myButton = GetComponent<Button> ();
	}
	
	// Update is called once per frame
	void Update () {
		ColorBlock cb = myButton.colors;
		cb.normalColor = PerkColor;
		cb.highlightedColor = PerkColor;
		cb.pressedColor = PerkColor;
		myButton.colors = cb;
		if (RandomPerk == 0) {
			PerkColor = new Color(0.35f, 0, 1f);
			Perk = "Disciple of Sobek";
			PerkName.text = Perk;
			Perk1 = RandomPerk;
		}
		if (RandomPerk == 1) {
			PerkColor = Color.cyan;
			Perk = "Marathon Man";
			PerkName.text = Perk;
			Perk1 = RandomPerk;
		}

		if (RandomPerk == 2) {
			PerkColor = Color.magenta;
			Perk = "Curse Denier";
			PerkName.text = Perk;
			Perk1 = RandomPerk;
		}

		if (RandomPerk == 3) {
			PerkColor = new Color (1f, 0.6f, 0.2f);
			Perk = "Need a Light";
			PerkName.text = Perk;
			Perk1 = RandomPerk;


		}
		if (RandomPerk == 4) {
			PerkColor = new Color (0.6f, 0.8f, 1f);
			Perk = "Close Reader";
			PerkName.text = Perk;
			Perk1 = RandomPerk;
		}

		if (RandomPerk == 5) {
			PerkColor = Color.green;
			Perk = "Hard Bargain";
			PerkName.text = Perk;
			Perk1 = RandomPerk;
		}

		if (RandomPerk == 6) {
			PerkColor = Color.red;
			Perk = "Intimidator";
			PerkName.text = Perk;
			Perk1 = RandomPerk;
		}

		if (RandomPerk == 7) {
			PerkColor = Color.yellow;
			Perk = "Collector";
			PerkName.text = Perk;
			Perk1 = RandomPerk;
		}

		if (RandomPerk == 9) {
			RandomPerk = 0;
		}

	
	}

	public void OnPointerEnter(PointerEventData eventData ) {
		PerkName.text = Perk;
		PerkName.enabled = true;
		PerkName2.enabled = false;
	}

	void TaskOnClick() {
		RandomPerk = RandomPerk + 1;
		PerkName.text = Perk;
	}
}
