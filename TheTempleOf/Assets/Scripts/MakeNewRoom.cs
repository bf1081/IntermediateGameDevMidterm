using UnityEngine;
using System.Collections;

public class MakeNewRoom : MonoBehaviour {

	public GameObject player;
	public float WhichRoom;
	public float SpawnEnemy;
	public GameObject enemy;
	public float RoomNumber;
	public float difficulty = 20;
	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {
		WhichRoom = Random.Range (1, 9);
		SpawnEnemy = Random.Range(1, 10);
		if (RoomNumber == 17) {
			difficulty = 40;
		}
	}


	void OnTriggerEnter(Collider teleport) {
		//Destroy (enemy);

		if (WhichRoom == 1) {
			player.transform.position = new Vector3 (-860, 1, -20);
			//player.transform.rotation.eulerAngles = new Vector3 (0, 180, 0);
		}
		if (WhichRoom == 2) {
			player.transform.position = new Vector3 (-855, 1, -5);
			//player.transform.rotation = new Vector3 (0, 0, 0);
		}
		if (WhichRoom == 3) {
			player.transform.position = new Vector3 (-825, 1, -1);
			//player.transform.rotation = new Vector3 (0, 90, 0);
		}
		if (WhichRoom == 4) {
			player.transform.position = new Vector3 (-986, 1, -23);
			//player.transform.rotation = new Vector3 (0, 0, 0);
		}
		if (WhichRoom == 5) {
			player.transform.position = new Vector3 (-994, 1, -76);
			//player.transform.rotation = new Vector3 (0, 0, 0);
		}
		if (WhichRoom == 6) {
			player.transform.position = new Vector3 (-994, 1, -76);
			//player.transform.rotation = new Vector3 (0, 0, 0);
		}
		if (WhichRoom == 7) {
			player.transform.position = new Vector3 (-1080, 1, -76);
			//player.transform.rotation = new Vector3 (0, 0, 0);
		}
		if (WhichRoom == 8) {
			player.transform.position = new Vector3 (-1056, 1, -26);
			//player.transform.rotation = new Vector3 (0, 0, 0);
		}
		if (WhichRoom == 9) {
			player.transform.position = new Vector3 (-1105, 1, -26);
			//player.transform.rotation = new Vector3 (0, 0, 0);
		}
		//spawn enemy
		if(WhichRoom == 9 && SpawnEnemy == 3) {
			Instantiate (enemy, new Vector3 (1110, 1, 3), Quaternion.identity);
		}
		if(WhichRoom == 8 && SpawnEnemy == 3) {
			Instantiate (enemy, new Vector3 (-1061, 1, -1), Quaternion.identity);
		}
		if(WhichRoom == 2 && SpawnEnemy == 3) {
			Instantiate (enemy, new Vector3 (-848, 1, 27), Quaternion.identity);
		}
		if(WhichRoom == 1 && SpawnEnemy == 3) {
			Instantiate (enemy, new Vector3 (-848, 1, -77), Quaternion.identity);
		}

		if(WhichRoom == 3 && SpawnEnemy == 3) {
			Instantiate (enemy, new Vector3 (-779, 1, 0), Quaternion.identity);
		}

		RoomNumber = RoomNumber + 1;

		//Make Enemy die when you leave room
		//make player die when collision occurs

	}
}
