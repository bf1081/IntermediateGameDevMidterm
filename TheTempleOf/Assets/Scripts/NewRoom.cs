using UnityEngine;
using System.Collections;


public class NewerRoom : MonoBehaviour {

	public GameObject player;
	public float WhichRoom;
	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		WhichRoom = Random.Range (1, 9) * Time.deltaTime;
	
	}


	void OnTriggerEnter(Collider teleport) {


		if (WhichRoom == 1) {
			player.transform.position = new Vector3 (-860, 1, -20);
			player.transform.eulerAngles = new Vector3(0, 180, 0);
		}
		if (WhichRoom == 2) {
			player.transform.position = new Vector3 (-855, 1, -5);
			player.transform.eulerAngles = new Vector3(0, 0, 0);
		}
		if (WhichRoom == 3) {
			Debug.Log("Testifiteorks");
			player.transform.position = new Vector3 (-825, 1, -1);
			//player.transform.rotation = new Vector3 (0, 90, 0);
			player.transform.eulerAngles = new Vector3(0,68,0); 
		}
		if (WhichRoom == 4) {
			player.transform.position = new Vector3 (-986, 1, -23);
			player.transform.eulerAngles = new Vector3(0, 0, 0);
		}
		if (WhichRoom == 5) {
			player.transform.position = new Vector3 (-994, 1, -76);
			player.transform.eulerAngles = new Vector3(0, 0, 0);
		}
		if (WhichRoom == 6) {
			player.transform.position = new Vector3 (-994, 1, -76);
			player.transform.eulerAngles = new Vector3(0, 0, 0);
		}
		if (WhichRoom == 7) {
			player.transform.position = new Vector3 (-1080, 1, -76);
			player.transform.eulerAngles = new Vector3(0, 0, 0);
		}
		if (WhichRoom == 8) {
			player.transform.position = new Vector3 (-1056, 1, -26);
			player.transform.eulerAngles = new Vector3(0, 0, 0);
		}
		if (WhichRoom == 9) {
			player.transform.position = new Vector3 (-1105, 1, -26);
			player.transform.eulerAngles = new Vector3(0, 0, 0);
		}



}
}
