using UnityEngine;
using System.Collections;

public class EnemyFollow : MonoBehaviour {

	public Transform target;
	public Transform myTransform;
	public float speed = 2;
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {

		target = GameObject.Find ("Player").transform;
		transform.LookAt (target);
		transform.Translate (Vector3.forward * speed * Time.deltaTime);
	

	}
}
