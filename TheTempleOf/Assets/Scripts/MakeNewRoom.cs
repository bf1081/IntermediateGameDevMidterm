using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MakeNewRoom : MonoBehaviour {

	public GameObject player;
	public float WhichRoom;
	public float SpawnEnemy;
	public float SpawnTreasure;
	public float SpawnBasket;
	public GameObject Lvl1enemy;
	public GameObject lvl2enemy;
	public GameObject treasure;
	public GameObject basket;
	public static int RoomNumber;
	public static int Gold;
	public int difficulty = 5;
	public Text RoomNumberText;
	public Text GoldAquired;
	public Light Shoplight;
	public int ColorPicker;
	public AudioSource audiosource;
	//public static int lives;
	//public Image Armor1;
	//public Image Armor2;
	//public Image Armor3;
	// Use this for initialization
	void Start () {

		RenderSettings.ambientIntensity = 0f;
		DynamicGI.UpdateEnvironment ();

	}

	// Update is called once per frame
	void Update () {

		if (Shop.Set == false) {
			WhichRoom = Random.Range (1, 11);
		}

		if (Shop.Set == true) {
			WhichRoom = Random.Range (1, 18);
		}
		SpawnEnemy = Random.Range(1, difficulty);
		SpawnTreasure = Random.Range (1, 6);
		SpawnBasket = Random.Range (1, 8);

		Shoplight = GameObject.Find ("Shoplight").GetComponent<Light>();

		if (RoomNumber == 10) {
			difficulty = 4;
		}
		if (RoomNumber == 15) {
			difficulty = 3;
		}
		if (RoomNumber == 20) {
			difficulty = 2;
		}
		if (RoomNumber == 25) {
			difficulty = 1;
		}

		if (RoomNumber >= 30 && RoomNumber < 40) {
			EnemyFollow.speed = 4f;
		}

		if (RoomNumber >= 40 && RoomNumber < 50) {
			EnemyFollow.speed = 6f;
		}

		if (RoomNumber >= 50 && RoomNumber < 60) {
			EnemyFollow.speed = 8f;
		}

		if (RoomNumber >= 80 && RoomNumber < 70) {
			EnemyFollow.speed = 10f;
		}

		if (RoomNumber >= 90 && RoomNumber < 120) {
			EnemyFollow.speed = 12f;
		}

		if (RoomNumber >= 120 && RoomNumber < 200) {
			EnemyFollow.speed = 20f;
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
		RoomNumberText.text = "Tomb " + RoomNumber.ToString ();
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
			//Debug.Log (RoomNumber);
			ColorPicker = Random.Range (1, 8);
			RoomNumber = RoomNumber + 1;

			Shop.cost1 = Random.Range (0, 2000);
			Shop.cost2 = Random.Range (0, 2000);
			Shop.cost3 = Random.Range (0, 2000);

			Sobek.costgold = Random.Range (0, 2000);
			Sobek.costcurse = Random.Range (0, 75);
			Sobek.costcurepages = Random.Range (0, 750);

			Shop.namechange = true;



			if (WhichRoom == 1) {
				player.transform.position = new Vector3 (-860, 1, -20);
				player.transform.eulerAngles = new Vector3 (0, 180, 0);
			}
			if (WhichRoom == 2) {
				player.transform.position = new Vector3 (-855, 1, -5);
				player.transform.eulerAngles = new Vector3 (0, 0, 0);
			}
			if (WhichRoom == 3) {

				player.transform.position = new Vector3 (-825, 1, -1);
				//player.transform.rotation = new Vector3 (0, 90, 0);
				player.transform.eulerAngles = new Vector3 (0, 68, 0); 
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
				player.transform.position = new Vector3 (-1105, 1, -26);
				player.transform.eulerAngles = new Vector3 (0, 0, 0);
			}

			if (WhichRoom == 10) {
				player.transform.position = new Vector3 (-1035, 1, -100);
				player.transform.eulerAngles = new Vector3 (0, 0, 0);
				Sobek.namechange = true;
			}
			if (WhichRoom == 11) {
				player.transform.position = new Vector3 (-1080, 1, -76);
				player.transform.eulerAngles = new Vector3 (0, 0, 0);
			}
			if (WhichRoom == 12) {
				player.transform.position = new Vector3 (-1080, 1, -76);
				player.transform.eulerAngles = new Vector3 (0, 0, 0);
			}
			if (WhichRoom == 13) {
				player.transform.position = new Vector3 (-1080, 1, -76);
				player.transform.eulerAngles = new Vector3 (0, 0, 0);
			}
			if (WhichRoom == 14) {
				player.transform.position = new Vector3 (-1080, 1, -76);
				player.transform.eulerAngles = new Vector3 (0, 0, 0);
			}

			if (WhichRoom == 15) {
				player.transform.position = new Vector3 (-1080, 1, -76);
				player.transform.eulerAngles = new Vector3 (0, 0, 0);
			}

			if (WhichRoom == 16) {
				player.transform.position = new Vector3 (-1080, 1, -76);
				player.transform.eulerAngles = new Vector3 (0, 0, 0);
			}
			if (WhichRoom == 17) {
				player.transform.position = new Vector3 (-1080, 1, -76);
				player.transform.eulerAngles = new Vector3 (0, 0, 0);
			}
			//spawn enemy
			if (WhichRoom == 9 && SpawnEnemy == 1 && RoomNumber < 30) {
				Instantiate (Lvl1enemy, new Vector3 (1110, 1, 3), Quaternion.identity);
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
			}
			if (WhichRoom == 3 && SpawnEnemy == 1 && RoomNumber >= 30) {
				Instantiate (lvl2enemy, new Vector3 (-779, 1, 0), Quaternion.identity);
			}




			// spawn treasure
			if (WhichRoom == 4 && SpawnTreasure == 2) {
				Instantiate (treasure, new Vector3 (-989, 1, 1), Quaternion.identity);
			}
			if (WhichRoom == 4 && SpawnTreasure == 1) {
				Instantiate (treasure, new Vector3 (-981, 1, -8), Quaternion.identity);
			}
			if (WhichRoom == 4 && SpawnTreasure == 3) {
				Instantiate (treasure, new Vector3 (-981, 1, -8), Quaternion.identity);
				Instantiate (treasure, new Vector3 (-989, 1, 1), Quaternion.identity);
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
			}
			if (WhichRoom == 3 && SpawnTreasure == 3) {
				Instantiate (treasure, new Vector3 (-796, 1, -6), Quaternion.identity);
			}

			if (WhichRoom == 2 && SpawnTreasure == 1) {
				Instantiate (treasure, new Vector3 (-5, 0, -1), Quaternion.identity);
			}
			if (WhichRoom == 2 && SpawnTreasure == 2) {
				Instantiate (treasure, new Vector3 (-854, 0, 22), Quaternion.identity);
			}
			if (WhichRoom == 2 && SpawnTreasure == 3) {
				Instantiate (treasure, new Vector3 (-5, 0, -1), Quaternion.identity);
				Instantiate (treasure, new Vector3 (-854, 0, 22), Quaternion.identity);
			}
			if (WhichRoom == 2 && SpawnTreasure == 2) {
				Instantiate (treasure, new Vector3 (-848, 1, 31), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnTreasure == 1) {
				Instantiate (treasure, new Vector3 (-853, 0, -53), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnTreasure == 2) {
				Instantiate (treasure, new Vector3 (-875, 1, -48), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnTreasure == 3) {
				Instantiate (treasure, new Vector3 (-873, 1, -72), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnTreasure == 4) {
				Instantiate (treasure, new Vector3 (-875, 1, -83), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnTreasure == 5) {
				Instantiate (treasure, new Vector3 (-853, 0, -53), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnTreasure == 6) {
				Instantiate (treasure, new Vector3 (-847, 1, -83), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnTreasure == 2) {
				Instantiate (treasure, new Vector3 (-843, 9, -84), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnTreasure == 3) {
				Instantiate (treasure, new Vector3 (-880, 9, -55), Quaternion.identity);
			}

			//spawn basket


			if (WhichRoom == 2 && SpawnBasket == 3) {
				Instantiate (basket, new Vector3 (-852, 0, 31), Quaternion.identity);
			}
			if (WhichRoom == 2 && SpawnBasket == 2) {
				Instantiate (basket, new Vector3 (-852, 0, 31), Quaternion.identity);
				Instantiate (basket, new Vector3 (-850, 1, 30), Quaternion.identity);
			}
			if (WhichRoom == 2 && SpawnBasket == 4) {
				Instantiate (basket, new Vector3 (-864, 1, 14), Quaternion.identity);
			}

			if (WhichRoom == 3 && SpawnBasket == 4) {
				Instantiate (basket, new Vector3 (-790, 1, 6), Quaternion.identity);
			}
			if (WhichRoom == 3 && SpawnBasket == 5) {
				Instantiate (basket, new Vector3 (-790, 0, -7), Quaternion.identity);
			}
			if (WhichRoom == 3 && SpawnBasket == 6) {
				Instantiate (basket, new Vector3 (-790, 0, -7), Quaternion.identity);
				Instantiate (basket, new Vector3 (-790, 1, 6), Quaternion.identity);
			}
			if (WhichRoom == 3 && SpawnBasket == 7) {
				Instantiate (basket, new Vector3 (-801, 0, -7), Quaternion.identity);
			}

			if (WhichRoom == 1 && SpawnBasket == 7) {
				Instantiate (basket, new Vector3 (-853, 1, -50), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnBasket == 6) {
				Instantiate (basket, new Vector3 (-853, 1, -50), Quaternion.identity);
				Instantiate (basket, new Vector3 (-853, 1, -48), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnBasket == 5) {
				Instantiate (basket, new Vector3 (-842, 1, -48), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnBasket == 4) {
				Instantiate (basket, new Vector3 (-879, 1, -48), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnBasket == 3) {
				Instantiate (basket, new Vector3 (-868, 1, -60), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnBasket == 2) {
				Instantiate (basket, new Vector3 (-854, 1, -60), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnBasket == 1) {
				Instantiate (basket, new Vector3 (-879, 1, -48), Quaternion.identity);
			}
			if (WhichRoom == 1 && SpawnBasket == 8) {
				Instantiate (basket, new Vector3 (-852, 1, -83), Quaternion.identity);
			}

			if (WhichRoom == 4 && SpawnBasket == 2) {
				Instantiate (basket, new Vector3 (-982, 2, -2), Quaternion.identity);
			}
			if (WhichRoom == 4 && SpawnBasket == 3) {
				Instantiate (basket, new Vector3 (-982, 2, 2), Quaternion.identity);
				Instantiate (basket, new Vector3 (-983, 3, 2), Quaternion.identity);
			}
			if (WhichRoom == 7 && SpawnBasket == 2) {
				Instantiate (basket, new Vector3 (-1085, 1, -62), Quaternion.identity);
			}
			if (WhichRoom == 7 && SpawnBasket == 5) {
				Instantiate (basket, new Vector3 (-1085, 1, -62), Quaternion.identity);
				Instantiate (basket, new Vector3 (-1083, 1, -62), Quaternion.identity);
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
