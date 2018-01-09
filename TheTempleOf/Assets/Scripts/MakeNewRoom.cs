using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MakeNewRoom : MonoBehaviour {

	public GameObject player;
	public float WhichRoom;
	public int WhichRoom2;
	public float SpawnEnemy;
	public float SpawnTreasure;
	public float SpawnBasket;
	public float SpawnScroll;
	public GameObject Lvl1enemy;
	public GameObject lvl2enemy;
	public GameObject treasure;
	public GameObject basket;
	public GameObject commonVase;
	public GameObject scroll;
	public GameObject crate;
	public GameObject CommonBasket;
	public static int RoomNumber;
	public static int Gold;
	public int difficulty = 5;
	public Text RoomNumberText;
	public Text GoldAquired;
	public Light Shoplight;
	public int ColorPicker;
	public AudioSource audiosource;
	public static int RoomTotal = 14;
	public GameObject Whisper;
	public GameObject WhisperEnemy;
	public int SpawnWhisper;
	public int whisperdifficulty = 5;
	public int WhichPainting;
	public GameObject Painting2;
	public GameObject Painting3;
	public GameObject Painting4;
	public GameObject Painting5;

	//public static int lives;
	//public Image Armor1;
	//public Image Armor2;
	//public Image Armor3;
	// Use this for initialization
	void Start () {

		RenderSettings.ambientIntensity = 0f;
		DynamicGI.UpdateEnvironment ();
		//Whisper = GameObject.Find ("Whisper");

	
	//	Painting2 = GameObject.Find ("WallPainting2");
	//	Painting3 = GameObject.Find ("WallPainting3");
	//	Painting4 = GameObject.Find ("WallPainting4");
	//	Painting5 = GameObject.Find ("WallPainting5");

	}

	// Update is called once per frame
	void Update () {


		WhichRoom2 = Random.Range (0, 5);
		//Whisper = GameObject.Find ("Whisper");

		SpawnWhisper = Random.Range (0, 15);

		if (Shop.Set == false) {
			WhichRoom = Random.Range (1, RoomTotal);
		}

		if (Shop.Set == true) {
			WhichRoom = Random.Range (1, 20);
		}
		SpawnEnemy = Random.Range(1, difficulty);
		SpawnTreasure = Random.Range (1, 6);
		SpawnBasket = Random.Range (1, 8);
		SpawnScroll = Random.Range (1, 12);

		Shoplight = GameObject.Find ("Shoplight").GetComponent<Light>();

		if (RoomNumber >= 10 && RoomNumber <= 14) {
			difficulty = 4;
		}
		if (RoomNumber >= 15 && RoomNumber <= 19) {
			difficulty = 3;
		}
		if (RoomNumber >= 20 && RoomNumber <= 24) {
			difficulty = 2;
		}
		if (RoomNumber >= 25) {
			difficulty = 1;
		}

		if (RoomNumber >= 30 && RoomNumber < 40 ) {
			EnemyFollow.diffspeed = 4f;
		}

		if (RoomNumber >= 40 && RoomNumber < 50) {
			EnemyFollow.diffspeed = 6f;
			whisperdifficulty = 4;
		}

		if (RoomNumber >= 50 && RoomNumber < 60 ) {
			EnemyFollow.diffspeed = 8f;
			whisperdifficulty = 3;
		}

		if (RoomNumber >= 80 && RoomNumber < 70 ) {
			EnemyFollow.diffspeed = 10f;
			whisperdifficulty = 2;
		
		}

		if (RoomNumber >= 90 && RoomNumber < 120) {
			EnemyFollow.diffspeed = 12f;
			whisperdifficulty = 1;
		}

		if (RoomNumber >= 120 && RoomNumber < 200) {
			EnemyFollow.diffspeed = 20f;
		}
	//	if (RoomNumber == 30) {
		//	difficulty = 5;
		//}
	//	if (RoomNumber == 35) {
		//	difficulty = 4;
		//}
	//	if (RoomNumber == 40) {
		//	difficulty = 3;
		//}
		//if (RoomNumber == 45) {
			//difficulty = 2;
		//}
	//	if (RoomNumber == 50) {
			//difficulty = 1;
		//}
		RoomNumberText.text = RoomNumber.ToString ();
		GoldAquired.text = Gold.ToString ();

		if( ColorPicker == 1) {
			Shoplight.color = Color.red;
		}
		if( ColorPicker == 2) {
			Shoplight.color = Color.blue;
		}
		if( ColorPicker == 3) {
			Shoplight.color = Color.green;
		}
		if( ColorPicker == 4) {
			Shoplight.color = Color.magenta;
		}
		if( ColorPicker == 5) {
			Shoplight.color = Color.cyan;
		}
		if( ColorPicker == 6) {
			Shoplight.color = Color.yellow;
		}
		if( ColorPicker == 7) {
			Shoplight.color = Color.white;
		}
		if( ColorPicker == 8) {
			Shoplight.color = Color.black;
		}

	}




	void OnTriggerEnter(Collider teleport) {
		//Destroy (enemy);
		if (teleport.tag == "Player") {

			//Destroy (Whisper);
			TheWhisper.IsWhispered = false;
			//Debug.Log (RoomNumber);
		
			ColorPicker = Random.Range (1, 8);
			RoomNumber = RoomNumber + 1;

			WhichPainting = Random.Range (0, 5);

			if (WhichPainting == 0) {

				Painting2.SetActive(false);
				Painting3.SetActive(false);
				Painting4.SetActive(false);
				Painting5.SetActive(false);
			


			}
			if (WhichPainting == 1) {
		
				Painting2.SetActive(true);
				Painting3.SetActive(false);
				Painting4.SetActive(false);
				Painting5.SetActive(false);


			}

			if (WhichPainting == 2) {

				Painting2.SetActive(false);
				Painting3.SetActive(true);
				Painting4.SetActive(false);
				Painting5.SetActive(false);


			}

			if (WhichPainting == 3) {
	
				Painting2.SetActive(false);
				Painting3.SetActive(false);
				Painting4.SetActive(true);
				Painting5.SetActive(false);


			}

			if (WhichPainting == 4) {

				Painting2.SetActive(false);
				Painting3.SetActive(false);
				Painting4.SetActive(false);
				Painting5.SetActive(true);


			}

		

			Shop.cost1 = Random.Range (0, Shop.ShopPrices);
			Shop.cost2 = Random.Range (0, Shop.ShopPrices);
			Shop.cost3 = Random.Range (0,Shop.ShopPrices);

			Sobek.costgold = Random.Range (0, 2000);
			Sobek.costcurse = Random.Range (0, 75);
			Sobek.costcurepages = Random.Range (0, 550);

			Shop.namechange = true;



			if (WhichRoom == 1 && WhichRoom2 != 3 && WhichRoom2 != 4 && WhichRoom2 != 2) {
				player.transform.position = new Vector3 (-860, 1, -20);
				player.transform.eulerAngles = new Vector3 (0, 180, 0);
			}

			if (WhichRoom == 2 && WhichRoom2 != 3 && WhichRoom2 != 4 && WhichRoom2 != 2) {
				
				player.transform.position = new Vector3 (-855, 1, -5);
				player.transform.eulerAngles = new Vector3 (0, 0, 0);
			}

			if (WhichRoom == 3 && WhichRoom2 != 3 && WhichRoom2 != 4 && WhichRoom2 != 2) {

				player.transform.position = new Vector3 (-825, 1, -1);
				//player.transform.rotation = new Vector3 (0, 90, 0);
				player.transform.eulerAngles = new Vector3 (0, 68, 0); 
			}


			if (WhichRoom == 1 && WhichRoom2 == 3) {
				player.transform.position = new Vector3 (-868.29f, 1, -248.89f);
				player.transform.eulerAngles = new Vector3 (0, 180, 0);
			}

			if (WhichRoom == 1 && WhichRoom2 == 4) {
				player.transform.position = new Vector3 (-868.29f, 1, -248.89f);
				player.transform.eulerAngles = new Vector3 (0, 180, 0);
			}

			if (WhichRoom == 1 && WhichRoom2 == 2) {
				player.transform.position = new Vector3 (-868.29f, 1, -248.89f);
				player.transform.eulerAngles = new Vector3 (0, 180, 0);
			}
			if (WhichRoom == 2 && WhichRoom2 == 2) {
				player.transform.position = new Vector3 (-847.2f, -1.87f, -286.6f);
				player.transform.eulerAngles = new Vector3 (0, 0, 0);
			}

			if (WhichRoom == 2 && WhichRoom2 == 3) {
				player.transform.position = new Vector3 (-847.2f, -1.87f, -286.6f);
				player.transform.eulerAngles = new Vector3 (0, 0, 0);
			}

			if (WhichRoom == 2 && WhichRoom2 == 4) {
				player.transform.position = new Vector3 (-847.2f, -1.87f, -286.6f);
				player.transform.eulerAngles = new Vector3 (0, 0, 0);
			}
			if (WhichRoom == 3 && WhichRoom2 == 2) {

				player.transform.position = new Vector3 (-922.7f, 2.17f, -24.66f);
				player.transform.eulerAngles = new Vector3 (0, 0, 0);

			}
			if (WhichRoom == 3 && WhichRoom2 == 3) {

				player.transform.position = new Vector3 (-922.7f, 2.17f, -24.66f);
				player.transform.eulerAngles = new Vector3 (0, 0, 0);

			}
			if (WhichRoom == 3 && WhichRoom2 == 4) {

				player.transform.position = new Vector3 (-922.7f, 2.17f, -24.66f);
				player.transform.eulerAngles = new Vector3 (0, 0, 0);

			}
			if (WhichRoom == 3 && WhichRoom2 == 5) {

				player.transform.position = new Vector3 (-922.7f, 2.17f, -24.66f);
				player.transform.eulerAngles = new Vector3 (0, 0, 0);

			}
			if (WhichRoom == 4) {
				player.transform.position = new Vector3 (-986, 1, -23);
				player.transform.eulerAngles = new Vector3 (0, 0, 0);
			}
			if (WhichRoom == 5) {
				player.transform.position = new Vector3 (-994, 1, -76);
				player.transform.eulerAngles = new Vector3 (0, 0, 0);
			}
			if (WhichRoom == 6) {
				player.transform.position = new Vector3 (-994, 1, -76);
				player.transform.eulerAngles = new Vector3 (0, 0, 0);
			}
			if (WhichRoom == 7) {
				player.transform.position = new Vector3 (-1080, 1, -76);
				player.transform.eulerAngles = new Vector3 (0, 0, 0);
			}
			if (WhichRoom == 8) {
				player.transform.position = new Vector3 (-1056, 1, -26);
				player.transform.eulerAngles = new Vector3 (0, 0, 0);
			}
			if (WhichRoom == 9) {
				player.transform.position = new Vector3 (-825, 1, -1);
				//player.transform.rotation = new Vector3 (0, 90, 0);
				player.transform.eulerAngles = new Vector3 (0, 68, 0); 
			}

	

			if (WhichRoom == 10) {
				player.transform.position = new Vector3 (-994, 1, -76);
				player.transform.eulerAngles = new Vector3 (0, 0, 0);
			}
			if (WhichRoom == 11) {
				player.transform.position = new Vector3 (-855, 1, -5);
				player.transform.eulerAngles = new Vector3 (0, 0, 0);
			}
			if (WhichRoom == 12) {
				player.transform.position = new Vector3 (-1080, 1, -76);
				player.transform.eulerAngles = new Vector3 (0, 0, 0);
			}
			if (WhichRoom == 13) {
				player.transform.position = new Vector3 (-1035, 1, -100);
				player.transform.eulerAngles = new Vector3 (0, 0, 0);
				Sobek.namechange = true;
			}
			if (WhichRoom == 14) {

				player.transform.position = new Vector3 (-1035, 1, -100);
				player.transform.eulerAngles = new Vector3 (0, 0, 0);
				Sobek.namechange = true;
			}

			if (WhichRoom == 15) {
				player.transform.position = new Vector3 (-1035, 1, -100);
				player.transform.eulerAngles = new Vector3 (0, 0, 0);
				Sobek.namechange = true;
			}

			if (WhichRoom == 16) {
				player.transform.position = new Vector3 (-1080, 1, -76);
				player.transform.eulerAngles = new Vector3 (0, 0, 0);
			}

			if (WhichRoom == 17) {
				player.transform.position = new Vector3 (-1080, 1, -76);
				player.transform.eulerAngles = new Vector3 (0, 0, 0);
			}

			if (WhichRoom == 18) {
				player.transform.position = new Vector3 (-1080, 1, -76);
				player.transform.eulerAngles = new Vector3 (0, 0, 0);
			}
			if (WhichRoom == 19) {
				player.transform.position = new Vector3 (-1080, 1, -76);
				player.transform.eulerAngles = new Vector3 (0, 0, 0);
			}

		

			//spawn enemy
			if (WhichRoom == 9 && SpawnEnemy == 1 && RoomNumber < 30) {
				Instantiate (Lvl1enemy, new Vector3 (1110, 1, 3), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnEnemy == 1 && RoomNumber < 30) {
				Instantiate (Lvl1enemy, new Vector3 (-934.73f, 1, 2.11f), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnEnemy == 2 && RoomNumber < 30) {
				Instantiate (Lvl1enemy, new Vector3 (-913.36f, 1, 1.27f), Quaternion.identity);
			}

			if (WhichRoom == 1 && SpawnEnemy == 1 && RoomNumber >= 30) {
				Instantiate (lvl2enemy, new Vector3 (-934.73f, 1, 2.11f), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnEnemy == 2 && RoomNumber >= 30) {
				Instantiate (lvl2enemy, new Vector3 (-913.36f, 1, 1.27f), Quaternion.identity);
			}

			if (WhichRoom == 8 && SpawnEnemy == 1 && RoomNumber < 30) {
				Instantiate (Lvl1enemy, new Vector3 (-1061, 1, -1), Quaternion.identity);
				audiosource.Play ();
			}
			if (WhichRoom == 2 && SpawnEnemy == 1 && RoomNumber < 30) {
				Instantiate (Lvl1enemy, new Vector3 (-848, 1, 27), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnEnemy == 1 && RoomNumber < 30) {
				Instantiate (Lvl1enemy, new Vector3 (-848, 1, -77), Quaternion.identity);
			}

			if (WhichRoom == 3 && SpawnEnemy == 1 && RoomNumber < 30) {
				Instantiate (Lvl1enemy, new Vector3 (-779, 1, 0), Quaternion.identity);
				audiosource.Play ();
			}

			if (WhichRoom == 9 && SpawnEnemy == 1 && RoomNumber >= 30) {
				Instantiate (lvl2enemy, new Vector3 (1110, 1, 3), Quaternion.identity);
			}

			if (WhichRoom == 8 && SpawnEnemy == 1 && RoomNumber >= 30) {
				Instantiate (lvl2enemy, new Vector3 (-1061, 1, -1), Quaternion.identity);
			}

			if (WhichRoom == 2 && SpawnEnemy == 1 && RoomNumber >= 30) {
				Instantiate (lvl2enemy, new Vector3 (-848, 1, 27), Quaternion.identity);
				audiosource.Play ();
			}

			if (WhichRoom == 1 && SpawnEnemy == 1 && RoomNumber >= 30) {
				Instantiate (lvl2enemy, new Vector3 (-848, 1, -77), Quaternion.identity);
				//Instantiate (Whisper, new Vector3 (-930, 10, -430), Quaternion.identity);
			}
			if (WhichRoom == 3 && SpawnEnemy == 1 && RoomNumber >= 30) {
				Instantiate (lvl2enemy, new Vector3 (-779, 1, 0), Quaternion.identity);
			}


			// spawn whisper

			if (TheWhisper.WhisperLives == true) {
				TheWhisper.WhisperLives = false;
			}

			if (SpawnWhisper == 1 && RoomNumber > 15 && SpawnEnemy == 1) {
				Instantiate (Whisper, new Vector3 (-930, 10, -430), Quaternion.identity);
				TheWhisper.WhisperLives = true;
			}
			if (SpawnWhisper == 2 && RoomNumber > 15 && SpawnEnemy == 1) {
				Instantiate (Whisper, new Vector3 (-930, 10, -430), Quaternion.identity);
				TheWhisper.WhisperLives = true;
			}
		
	

			// spawn treasure
			if (WhichRoom == 4 && SpawnTreasure == 2) {
				Instantiate (treasure, new Vector3 (-989, 1, 1), Quaternion.identity);
				Instantiate (basket, new Vector3 (-869.82f, -2, -267.4f), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);

			}
			if (WhichRoom == 4 && SpawnTreasure == 1) {
				Instantiate (treasure, new Vector3 (-981, 1, -8), Quaternion.identity);
				Instantiate (basket, new Vector3 (-869.82f, -2, -267.4f), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);

			}
			if (WhichRoom == 4 && SpawnTreasure == 3) {
				Instantiate (treasure, new Vector3 (-981, 1, -8), Quaternion.identity);
				Instantiate (treasure, new Vector3 (-989, 1, 1), Quaternion.identity);
				Instantiate (treasure, new Vector3 (-989, 1, 1), Quaternion.identity);
				Instantiate (basket, new Vector3 (-869.82f, -2, -267.4f), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
			}

			if (WhichRoom == 5 && SpawnTreasure == 2) {
				Instantiate (treasure, new Vector3 (-1000, 1, -61), Quaternion.identity);
			}
			if (WhichRoom == 5 && SpawnTreasure == 3) {
				Instantiate (treasure, new Vector3 (-993, 1, -56), Quaternion.identity);
			}
			if (WhichRoom == 5 && SpawnTreasure == 4) {
				Instantiate (treasure, new Vector3 (-991, 1, -52), Quaternion.identity);
			}
			if (WhichRoom == 5 && SpawnTreasure == 5) {
				Instantiate (treasure, new Vector3 (-993, 1, -56), Quaternion.identity);
				Instantiate (treasure, new Vector3 (-1000, 1, -61), Quaternion.identity);
			}
			if (WhichRoom == 3 && SpawnTreasure == 4) {
				Instantiate (treasure, new Vector3 (-791, 1, 5), Quaternion.identity);
			}
			if (WhichRoom == 3 && SpawnTreasure == 5) {
				Instantiate (treasure, new Vector3 (-810, 1, -5), Quaternion.identity);
			}
			if (WhichRoom == 3 && SpawnTreasure == 6) {
				Instantiate (treasure, new Vector3 (-810, 1, 5), Quaternion.identity);
				Instantiate (basket, new Vector3 (-852, 0, 31), Quaternion.identity);
				Instantiate (basket, new Vector3 (-850, 1, 30), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);

			}
			if (WhichRoom == 3 && SpawnTreasure == 3) {
				Instantiate (treasure, new Vector3 (-796, 1, -6), Quaternion.identity);
				Instantiate (basket, new Vector3 (-852, 0, 31), Quaternion.identity);
				Instantiate (basket, new Vector3 (-850, 1, 30), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);

			}

			if (WhichRoom == 3 && SpawnTreasure == 3) {
				Instantiate (treasure, new Vector3 (-796, 1, -6), Quaternion.identity);
				Instantiate (basket, new Vector3 (-852, 0, 31), Quaternion.identity);
				Instantiate (basket, new Vector3 (-850, 1, 30), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);

			}

			if (WhichRoom == 3 && SpawnTreasure == 3) {
				Instantiate (treasure, new Vector3 (-796, 1, -6), Quaternion.identity);
				Instantiate (basket, new Vector3 (-852, 0, 31), Quaternion.identity);
				Instantiate (basket, new Vector3 (-850, 1, 30), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);

			}

		
			if (WhichRoom == 2 && SpawnTreasure == 3) {
				Instantiate (basket, new Vector3 (-864, 1, 14), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (treasure, new Vector3 (-5, 1, -1), Quaternion.identity);
				Instantiate (treasure, new Vector3 (-854, 1, 22), Quaternion.identity);
			}
			if (WhichRoom == 2 && SpawnTreasure == 2) {

				Instantiate (treasure, new Vector3 (-848, 1, 31), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnTreasure == 1) {
				Instantiate (basket, new Vector3 (-864, 1, 14), Quaternion.identity);

				Instantiate (treasure, new Vector3 (-853, 1, -53), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnTreasure == 2) {
				Instantiate (basket, new Vector3 (-864, 1, 14), Quaternion.identity);
		
				Instantiate (treasure, new Vector3 (-875, 1, -48), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnTreasure == 3) {

				Instantiate (treasure, new Vector3 (-873, 1, -72), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnTreasure == 4) {
				Instantiate (basket, new Vector3 (-853, 1, -50), Quaternion.identity);

				Instantiate (treasure, new Vector3 (-875, 1, -83), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnTreasure == 5) {
				Instantiate (basket, new Vector3 (-853, 1, -50), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (treasure, new Vector3 (-853, 1, -53), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnTreasure == 6) {
		
				Instantiate (treasure, new Vector3 (-847, 1, -83), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnTreasure == 2) {
				Instantiate (basket, new Vector3 (-853, 1, -50), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (treasure, new Vector3 (-843, 9, -84), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnTreasure == 3) {
				Instantiate (basket, new Vector3 (-853, 1, -50), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (treasure, new Vector3 (-880, 9, -55), Quaternion.identity);
			}

			//spawn basket


	



			if (WhichRoom == 2 && SpawnBasket == 2) {
				Instantiate (basket, new Vector3 (-852, 0, 31), Quaternion.identity);
				Instantiate (basket, new Vector3 (-850, 1, 30), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);

			}

			if (WhichRoom == 2 && SpawnBasket == 2) {
				Instantiate (basket, new Vector3 (-852, 0, 31), Quaternion.identity);
				Instantiate (basket, new Vector3 (-850, 1, 30), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);

			}
			if (WhichRoom == 2 && SpawnBasket == 4) {
				Instantiate (basket, new Vector3 (-864, 1, 14), Quaternion.identity);
	
			}

			if (WhichRoom == 3 && SpawnBasket == 4) {
				Instantiate (basket, new Vector3 (-790, 1, 6), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
			}

			if (WhichRoom == 3 && SpawnBasket == 4) {
				Instantiate (basket, new Vector3 (-790, 1, 6), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
			}

		

			if (WhichRoom == 3 && SpawnBasket == 5) {
				Instantiate (basket, new Vector3 (-790, 0, -7), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
			}

			if (WhichRoom == 3 && SpawnBasket == 5) {
				Instantiate (basket, new Vector3 (-790, 0, -7), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
			}
		
			if (WhichRoom == 3 && SpawnBasket == 7) {
				Instantiate (basket, new Vector3 (-801, 0, -7), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
			}

			if (WhichRoom == 3 && SpawnBasket == 7) {
				Instantiate (basket, new Vector3 (-801, 0, -7), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
			}

			if (WhichRoom == 3 && SpawnBasket == 7) {
				Instantiate (basket, new Vector3 (-801, 0, -7), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
			}

			if (WhichRoom == 1 && SpawnBasket == 7) {
				Instantiate (basket, new Vector3 (-853, 1, -50), Quaternion.identity);

			}

			if (WhichRoom == 1 && SpawnBasket == 7) {
				Instantiate (basket, new Vector3 (-924.8f, 1, 6.66f), Quaternion.identity);
		
			}
			if (WhichRoom == 1 && SpawnBasket == 5) {
				Instantiate (crate, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (basket, new Vector3 (-899.2f, 1, 5.69f), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnBasket == 5) {
				Instantiate (basket, new Vector3 (-904f, 1, 5.69f), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnBasket == 4) {
				Instantiate (basket, new Vector3 (-949.24f, 1, -5.41f), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnBasket == 4) {
				Instantiate (basket, new Vector3 (-945.1f, 1, -5.41f), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
			}

			if (WhichRoom == 1 && SpawnBasket == 6) {
				Instantiate (basket, new Vector3 (-921.9f, 1, 6.66f), Quaternion.identity);
				Instantiate (basket, new Vector3 (-909f, 1, 2.87f), Quaternion.identity);
				Instantiate (basket, new Vector3 (-853, 1, -50), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (treasure, new Vector3 (-880, 9, -55), Quaternion.identity);
			}

			if (WhichRoom == 1 && SpawnBasket == 7) {
				Instantiate (basket, new Vector3 (-853, 1, -50), Quaternion.identity);
				Instantiate (basket, new Vector3 (-801, 0, -7), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
			}

			if (WhichRoom == 1 && SpawnBasket == 6 && WhichRoom == 3) {
				Instantiate (basket, new Vector3 (-869.82f, -2, -267.4f), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);

			}
			if (WhichRoom == 1 && SpawnBasket == 6 && WhichRoom == 2) {
				Instantiate (basket, new Vector3 (-869.82f, -2, -267.4f), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);

			}
			if (WhichRoom == 1 && SpawnBasket == 6 && WhichRoom == 4) {
				Instantiate (basket, new Vector3 (-866.54f, -4, -272.96f), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);

			}
			if (WhichRoom == 1 && SpawnBasket == 5) {
				Instantiate (basket, new Vector3 (-842, 1, -48), Quaternion.identity);
				Instantiate (basket, new Vector3 (-869.82f, -2, -267.4f), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-988f,-1001f), 1, Random.Range(-63f,-50f)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-988f,-1001f), 1, Random.Range(-63f,-50f)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-988f,-1001f), 1, Random.Range(-63f,-50f)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-988f,-1001f), 1, Random.Range(-63f,-50f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-988f,-1001f), 1, Random.Range(-63f,-50f)), Quaternion.identity);

			}
			if (WhichRoom == 1 && SpawnBasket == 4) {
				Instantiate (basket, new Vector3 (-879, 1, -48), Quaternion.identity);
				Instantiate (basket, new Vector3 (-869.82f, -2, -267.4f), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-988f,-1001f), 1, Random.Range(-63f,-50f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-988f,-1001f), 1, Random.Range(-63f,-50f)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-988f,-1001f), 1, Random.Range(-63f,-50f)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-988f,-1001f), 1, Random.Range(-63f,-50f)), Quaternion.identity);

			}
			if (WhichRoom == 1 && SpawnBasket == 3) {
				Instantiate (basket, new Vector3 (-868, 1, -60), Quaternion.identity);
				Instantiate (basket, new Vector3 (-869.82f, -2, -267.4f), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-988f,-1001f), 1, Random.Range(-63f,-50f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-988f,-1001f), 1, Random.Range(-63f,-50f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-988f,-1001f), 1, Random.Range(-63f,-50f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-988f,-1001f), 1, Random.Range(-63f,-50f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-988f,-1001f), 1, Random.Range(-63f,-50f)), Quaternion.identity);

			}

			if (WhichRoom == 2 && SpawnBasket == 3) {
				Instantiate (basket, new Vector3 (-868, 1, -60), Quaternion.identity);
				Instantiate (basket, new Vector3 (-869.82f, -2, -267.4f), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);

			}

			if (WhichRoom == 3 && SpawnBasket == 3) {
				Instantiate (basket, new Vector3 (-868, 1, -60), Quaternion.identity);
				Instantiate (basket, new Vector3 (-869.82f, -2, -267.4f), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);

			}

			if (WhichRoom == 4 && SpawnBasket == 3) {
				Instantiate (basket, new Vector3 (-868, 1, -60), Quaternion.identity);
				Instantiate (basket, new Vector3 (-869.82f, -2, -267.4f), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);

			}

			if (WhichRoom == 5 && SpawnBasket == 3) {
				Instantiate (basket, new Vector3 (-868, 1, -60), Quaternion.identity);
				Instantiate (basket, new Vector3 (-869.82f, -2, -267.4f), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);

			}

			if (WhichRoom == 6 && SpawnBasket == 3) {
				Instantiate (basket, new Vector3 (-868, 1, -60), Quaternion.identity);
				Instantiate (basket, new Vector3 (-869.82f, -2, -267.4f), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);

			}

			if (WhichRoom == 7 && SpawnBasket == 3) {
				Instantiate (basket, new Vector3 (-868, 1, -60), Quaternion.identity);
				Instantiate (basket, new Vector3 (-869.82f, -2, -267.4f), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);

			}

			if (WhichRoom == 8 && SpawnBasket == 3) {
				Instantiate (basket, new Vector3 (-868, 1, -60), Quaternion.identity);
				Instantiate (basket, new Vector3 (-869.82f, -2, -267.4f), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);

			}

			if (WhichRoom == 9 && SpawnBasket == 3) {
				Instantiate (basket, new Vector3 (-868, 1, -60), Quaternion.identity);
				Instantiate (basket, new Vector3 (-869.82f, -2, -267.4f), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);

			}
			if (WhichRoom == 1 && SpawnBasket == 2) {
				Instantiate (basket, new Vector3 (-854, 1, -60), Quaternion.identity);
				Instantiate (basket, new Vector3 (-869.82f, -2, -267.4f), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);

			}
			if (WhichRoom == 1 && SpawnBasket == 1) {
				Instantiate (basket, new Vector3 (-879, 1, -48), Quaternion.identity);
				Instantiate (basket, new Vector3 (-801, 0, -7), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
			}

			if (WhichRoom == 3) {

				Instantiate (crate, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
			}
			if (WhichRoom == 4) {

				Instantiate (crate, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
			}
			if (WhichRoom == 2) {

				Instantiate (crate, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(7.69f,30), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-880,-835), 1, Random.Range(-90,-34)), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnBasket == 8) {
				Instantiate (basket, new Vector3 (-852, 1, -83), Quaternion.identity);
				Instantiate (basket, new Vector3 (-801, 0, -7), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
			}

			if (WhichRoom == 4 && SpawnBasket == 2) {
				Instantiate (basket, new Vector3 (-982, 2, -2), Quaternion.identity);
				Instantiate (basket, new Vector3 (-801, 0, -7), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
			}
			if (WhichRoom == 4 && SpawnBasket == 3) {
				Instantiate (basket, new Vector3 (-982, 2, 2), Quaternion.identity);
				Instantiate (basket, new Vector3 (-983, 3, 2), Quaternion.identity);
			}
			if (WhichRoom == 7 && SpawnBasket == 2) {
				Instantiate (basket, new Vector3 (-1085, 1, -62), Quaternion.identity);
				Instantiate (basket, new Vector3 (-801, 0, -7), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-813,-776), 1, Random.Range(-11,11)), Quaternion.identity);
			}
			if (WhichRoom == 7 && SpawnBasket == 5) {
				Instantiate (basket, new Vector3 (-1085, 1, -62), Quaternion.identity);
				Instantiate (basket, new Vector3 (-1083, 1, -62), Quaternion.identity);
				Instantiate (basket, new Vector3 (-866.54f, -4, -272.96f), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
			}
			if (WhichRoom == 6 && SpawnBasket == 5) {
				Instantiate (basket, new Vector3 (-1085, 1, -62), Quaternion.identity);
				Instantiate (basket, new Vector3 (-1083, 1, -62), Quaternion.identity);
				Instantiate (basket, new Vector3 (-866.54f, -4, -272.96f), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-952.7f,-869.6f), 1, Random.Range(-11,11.55f)), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnBasket == 5) {
				Instantiate (basket, new Vector3 (-1085, 1, -62), Quaternion.identity);
				Instantiate (basket, new Vector3 (-1083, 1, -62), Quaternion.identity);
				Instantiate (basket, new Vector3 (-866.54f, -4, -272.96f), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-988.5f,-1003f), 1, Random.Range(-51,-62f)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-988.5f,-1003f), 1, Random.Range(-51,-62f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-988.5f,-1003f), 1, Random.Range(-51,-62f)), Quaternion.identity);
			}
			if (WhichRoom == 4 && SpawnBasket == 5) {
				Instantiate (basket, new Vector3 (-1085, 1, -62), Quaternion.identity);
				Instantiate (basket, new Vector3 (-1083, 1, -62), Quaternion.identity);
				Instantiate (basket, new Vector3 (-866.54f, -4, -272.96f), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-988.5f,-1003f), 1, Random.Range(-51,-62f)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-988.5f,-1003f), 1, Random.Range(-51,-62f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-988.5f,-1003f), 1, Random.Range(-51,-62f)), Quaternion.identity);
			}
			if (WhichRoom == 3 && SpawnBasket == 5) {
				Instantiate (basket, new Vector3 (-1085, 1, -62), Quaternion.identity);
				Instantiate (basket, new Vector3 (-1083, 1, -62), Quaternion.identity);
				Instantiate (basket, new Vector3 (-866.54f, -4, -272.96f), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-988.5f,-1003f), 1, Random.Range(-51,-62f)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-988.5f,-1003f), 1, Random.Range(-51,-62f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-988.5f,-1003f), 1, Random.Range(-51,-62f)), Quaternion.identity);
			}
			if (WhichRoom == 2 && SpawnBasket == 5) {
				Instantiate (basket, new Vector3 (-1085, 1, -62), Quaternion.identity);
				Instantiate (basket, new Vector3 (-1083, 1, -62), Quaternion.identity);
				Instantiate (basket, new Vector3 (-866.54f, -4, -272.96f), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-988.5f,-1003f), 1, Random.Range(-51,-62f)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-988.5f,-1003f), 1, Random.Range(-51,-62f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-988.5f,-1003f), 1, Random.Range(-51,-62f)), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnBasket == 5) {
				Instantiate (basket, new Vector3 (-1085, 1, -62), Quaternion.identity);
				Instantiate (basket, new Vector3 (-1083, 1, -62), Quaternion.identity);
				Instantiate (basket, new Vector3 (-866.54f, -4, -272.96f), Quaternion.identity);
				Instantiate (CommonBasket, new Vector3 (Random.Range(-988.5f,-1003f), 1, Random.Range(-51,-62f)), Quaternion.identity);
				Instantiate (commonVase, new Vector3 (Random.Range(-988.5f,-1003f), 1, Random.Range(-51,-62f)), Quaternion.identity);
				Instantiate (crate, new Vector3 (Random.Range(-988.5f,-1003f), 1, Random.Range(-51,-62f)), Quaternion.identity);
			}

			if (WhichRoom == 8 && SpawnBasket == 2) {
				Instantiate (basket, new Vector3 (-1053, 1, -2), Quaternion.identity);
			}
			if (WhichRoom == 8 && SpawnBasket == 3) {
				Instantiate (basket, new Vector3 (-1061, 1, -5), Quaternion.identity);
			}

			if (WhichRoom == 5 && SpawnBasket == 3) {
				Instantiate (basket, new Vector3 (-990, 1, -57), Quaternion.identity);
			}


			// Spawn Scrolls

			if (WhichRoom == 1 && SpawnScroll == 2) {
				Instantiate (scroll, new Vector3 (-864, 0, -58), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnScroll == 2) {
				Instantiate (scroll, new Vector3 (-919.84f, 0, -5.14f), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnScroll == 3) {
				Instantiate (scroll, new Vector3 (-857, 1, -58), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnScroll == 4) {
				Instantiate (scroll, new Vector3 (-857, 1, -58), Quaternion.identity);
				Instantiate (scroll, new Vector3 (-864, 0, -58), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnScroll == 5) {
				Instantiate (scroll, new Vector3 (-850, 1, -42), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnScroll == 6) {
				Instantiate (scroll, new Vector3 (-871, 1, -37), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnScroll == 7) {
				Instantiate (scroll, new Vector3 (-846, 1, -78), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnScroll == 8) {
				Instantiate (scroll, new Vector3 (-846f, 1, -78.54f), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnScroll == 9) {
				Instantiate (scroll, new Vector3 (-846f, 1, -78.54f), Quaternion.identity);
				Instantiate (scroll, new Vector3 (-846, 1, -78), Quaternion.identity);
			}

			if (WhichRoom == 2 && SpawnScroll == 2) {
				Instantiate (scroll, new Vector3 (-861, 0, 21f), Quaternion.identity);
			}
			if (WhichRoom == 2 && SpawnScroll == 3) {
				Instantiate (scroll, new Vector3 (-847, 1, 16f), Quaternion.identity);
			}
			if (WhichRoom == 2 && SpawnScroll == 4) {
				Instantiate (scroll, new Vector3 (-847, 1, 13f), Quaternion.identity);
			}
			if (WhichRoom == 2 && SpawnScroll == 5) {
				Instantiate (scroll, new Vector3 (-859, 1, 32f), Quaternion.identity);
			}
			if (WhichRoom == 2 && SpawnScroll == 6) {
				Instantiate (scroll, new Vector3 (-853, 1, 32f), Quaternion.identity);
			}
			if (WhichRoom == 2 && SpawnScroll == 7) {
				Instantiate (scroll, new Vector3 (-853, 1, 32f), Quaternion.identity);
				Instantiate (scroll, new Vector3 (-859, 1, 32f), Quaternion.identity);
			}
			if (WhichRoom == 5 && SpawnScroll == 6) {
				Instantiate (scroll, new Vector3 (-990, 0.2f, -61.3f), Quaternion.identity);
			}

			if (WhichRoom == 5 && SpawnScroll == 4) {
				Instantiate (scroll, new Vector3 (-1038, 0.75f, -62.4f), Quaternion.identity);
			}
			if (WhichRoom == 5 && SpawnScroll == 7) {
				Instantiate (scroll, new Vector3 (-1032, 1.23f, -62.4f), Quaternion.identity);
			}

			if (WhichRoom == 7 && SpawnScroll == 10) {
				Instantiate (scroll, new Vector3 (-1052, 0.22f, 6.8f), Quaternion.identity);
			}
			if (WhichRoom == 7 && SpawnScroll == 11) {
				Instantiate (scroll, new Vector3 (-1053, 0.66f, -1f), Quaternion.identity);
			}
			if (WhichRoom == 3 && SpawnScroll == 4) {
				Instantiate (scroll, new Vector3 (-805, 0.3f, -7), Quaternion.identity);
			}
			if (WhichRoom == 3 && SpawnScroll == 3) {
				Instantiate (scroll, new Vector3 (-799,-0.5f, 6.27f), Quaternion.identity);
			}
			// Which color for shop?

			if (ColorPicker == 1) {
			
			}

		



		}

		if (Shop.WhichItem1 == "Worn Boots") {
			Shop.cost1 = Random.Range (50, 200);
		}
		if (Shop.WhichItem2 == "Worn Boots") {
			Shop.cost2 = Random.Range (50, 200);
		}
		if (Shop.WhichItem3 == "Worn Boots") {
			Shop.cost3 = Random.Range (50, 200);
		}
		if (Shop.WhichItem1 == "Leather Shoes") {
			Shop.cost1 = Random.Range (100, 450);
		}
		if (Shop.WhichItem2 == "Leather Shoes") {
			Shop.cost2 = Random.Range (100, 450);
		}
		if (Shop.WhichItem3 == "Leather Shoes") {
			Shop.cost3 = Random.Range (100, 450);
		}

		if (Shop.WhichItem1 == "Pace of Thoth") {
			Shop.cost1 = Random.Range (500, 2000);
		}
		if (Shop.WhichItem2 == "Pace of Thoth") {
			Shop.cost2 = Random.Range (500, 2000);
		}
		if (Shop.WhichItem3 == "Pace of Thoth") {
			Shop.cost3 = Random.Range (500, 2000);
		}
		if (Shop.WhichItem1 == "Palm Torch") {
			Shop.cost1 = Random.Range (115, 300);
		}
		if (Shop.WhichItem2 == "Palm Torch") {
			Shop.cost2 = Random.Range (115, 300);
		}
		if (Shop.WhichItem3 == "Palm Torch") {
			Shop.cost3 = Random.Range (115, 300);
		}

		if (Shop.WhichItem1 == "Acacia Torch") {
			Shop.cost1 = Random.Range (250, 500);
		}
		if (Shop.WhichItem2 == "Acacia Torch") {
			Shop.cost2 = Random.Range (250, 500);
		}
		if (Shop.WhichItem3 == "Acacia Torch") {
			Shop.cost3 = Random.Range (250, 500);
		}
		if (Shop.WhichItem1 == "Sycomore Torch") {
			Shop.cost1 = Random.Range (550, 1000);
		}

		if (Shop.WhichItem2 == "Sycomore Torch") {
			Shop.cost2 = Random.Range (550, 1000);
		}

		if (Shop.WhichItem3 == "Sycomore Torch") {
			Shop.cost3 = Random.Range (550, 1000);
		}
		//RoomNumber = RoomNumber + 1;

		//Make Enemy die when you leave room
		//make player die when collision occurs

	}
		
}
