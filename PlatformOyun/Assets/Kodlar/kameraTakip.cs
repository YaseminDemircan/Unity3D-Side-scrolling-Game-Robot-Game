using UnityEngine;
using System.Collections;

public class kameraTakip : MonoBehaviour {

	public Transform karakter; //takip edilen sey
	public float hizCamera;

	Vector3 offset;

	float minY;

	// Use this for initialization
	void Start () {
		offset = transform.position - karakter.position;

		minY = transform.position.y;

	}


	void FixedUpdate () {

		Vector3 karakterCamPos = karakter.position + offset;

		transform.position = Vector3.Lerp (transform.position,karakterCamPos,hizCamera*Time.deltaTime);

		if (transform.position.y < minY)
			transform.position = new Vector3 (transform.position.x,minY,transform.position.z);
	}
}
