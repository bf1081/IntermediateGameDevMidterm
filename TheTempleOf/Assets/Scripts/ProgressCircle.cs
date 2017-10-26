using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ProgressCircle : MonoBehaviour {

	public GameObject LoadingBar;
	public Transform TextIndicator;
	//public Transform TextLoading;
	[SerializeField] private float currentAmount;
	[SerializeField] private float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		LoadingBar.GetComponent<Image> ().fillAmount = currentAmount / 100;

		if(currentAmount < 100) {
			currentAmount += speed * Time.deltaTime;
			TextIndicator.GetComponent<Text> ().text = ((int)currentAmount).ToString () + "%";
			//TextLoading.gameObject.SetActive(true);

		}else{
			//TextLoading.gameObject.SetActive (false);
			//TextIndicator.GetComponent<Text>().text


		}

	}
}
