using UnityEngine;
using System.Collections;

public class MouseFollow : MonoBehaviour {

	float verticalLook = 0f; // remember our vertical mouse look eulerAngle (X axis)
	public float mouseSensitivity = 100f;

	// Use this for initialization
	void Start () {
		

	}

	// Update is called once per frame
	void Update () {
		if (Shop.ShopUIUp == false) {
			float mouseX = Input.GetAxis ("Mouse X");
			float mouseY = Input.GetAxis ("Mouse Y");
			Cursor.visible = false;
			Cursor.lockState = CursorLockMode.Locked;
			transform.Rotate (-mouseY, 0f, 0f);
			transform.parent.Rotate (0f, mouseX * Time.deltaTime * mouseSensitivity, 0f);

			//mouse-look vertical clamp
			verticalLook -= mouseY * Time.deltaTime * mouseSensitivity;
			verticalLook = Mathf.Clamp (verticalLook, -85f, 85f); // don't let player look past 85 degrees up or down


			//correction pass: un-roll the camera? manually override Z eulerAngle to 0
			transform.localEulerAngles = new Vector3 (verticalLook, transform.localEulerAngles.y, 0f);

			if (Input.GetMouseButtonDown (0)) { // 0 = left, 1 = right, 2 = middle
				Cursor.visible = false;
				Cursor.lockState = CursorLockMode.Locked; //locks mouse cursor to center of window
			}
			//if (Input.GetMouseButtonUp(0)) {
			//Cursor.visible = true;
			//Cursor.lockState = CursorLockMode.None;
			//}
		}

		if (Shop.ShopUIUp == true) {
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
		}
	}
}
