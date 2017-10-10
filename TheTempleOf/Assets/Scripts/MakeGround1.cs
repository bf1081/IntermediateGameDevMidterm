using UnityEngine;
using System.Collections;

public class MakeGround1 : MonoBehaviour {

	public GameObject generationright;
	public GameObject generationleft;
	public GameObject generationup;
	public GameObject generationdown;
	public GameObject CurrentBoundary;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider wall) {
		if (wall.tag == "Player") {
			if (gameObject.tag == "1") {
				Instantiate (generationright, new Vector3 (generationright.transform.position.x, 0, generationright.transform.position.z + 30), Quaternion.identity);
				Destroy (CurrentBoundary.gameObject);

			}
			if (gameObject.tag == "2") {
				Instantiate (generationleft, new Vector3 (generationleft.transform.position.x, 0, generationleft.transform.position.z - 30), Quaternion.identity);
				Destroy (CurrentBoundary.gameObject);

			}
			if (gameObject.tag == "3") {
				Instantiate (generationup, new Vector3 (generationup.transform.position.x + 30, 0, generationup.transform.position.z), Quaternion.identity);
				Destroy (CurrentBoundary.gameObject);

			}
			if (gameObject.tag == "4") {
				Instantiate (generationdown, new Vector3 (generationdown.transform.position.x - 30, 0, generationdown.transform.position.z), Quaternion.identity);
				Destroy (CurrentBoundary.gameObject);

			}



		}
	}
}
