using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class progress_bar_Cyris_BIIIITHC : MonoBehaviour {

	public static float Fill_Amount_Cyrus;
	Image Our_Image;
	public Text Percent_Text;
	//public AudioSource myaudiosource;


	public float time_To_Load;


	// Use this for initialization
	void Start () {
		Our_Image = GetComponent<Image> ();
		//AudioSource = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		Our_Image.fillAmount = Fill_Amount_Cyrus;
		Percent_Text.text = string.Format ("{0:0}", Fill_Amount_Cyrus * 100);
	
		if (Input.GetKey (KeyCode.E) && Fill_Amount_Cyrus < 0.99 && BasicLootCrates.isIn == true) {
			Fill_Amount_Cyrus = Mathf.Lerp (Fill_Amount_Cyrus, Fill_Amount_Cyrus + .1f * time_To_Load, Time.deltaTime);
		
		} else {
			if (Fill_Amount_Cyrus > 0.01) {
				Fill_Amount_Cyrus = Mathf.Lerp (Fill_Amount_Cyrus, Fill_Amount_Cyrus - .1f * time_To_Load, Time.deltaTime);

			}
		}
	}
}


		






