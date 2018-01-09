﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitletoPerkScreen : MonoBehaviour {
	public Button myButton;
	// Use this for initialization
	void Start () {
		Button btn = myButton.GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void TaskOnClick() {
		SceneManager.LoadScene ("PickYourPerk", LoadSceneMode.Single);
	}
}
