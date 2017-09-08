using UnityEngine;
using System.Collections;

public class tuzakZarar : MonoBehaviour {

	public float zarar;
	public float zararOran;
	public float itmeKuvvet;

	float sonrakiZarar;

	void Start () {

		sonrakiZarar = 0f;
	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerStay2D(Collider2D nesne){
		if (nesne.tag == "Player" && sonrakiZarar < Time.time) {
			oyuncuCan can = nesne.gameObject.GetComponent<oyuncuCan> ();
			can.zararVer(zarar);
			sonrakiZarar= Time.time * zararOran;

			pushBack (nesne.transform);
		}

	}
	void pushBack(Transform itmeNesne){
		Vector2 itmeYon = new Vector2 (0, (itmeNesne.position.y-transform.position.y)).normalized;
		itmeYon *= itmeKuvvet;
		Rigidbody2D itmeRB = itmeNesne.gameObject.GetComponent<Rigidbody2D> ();
		itmeRB.velocity = Vector2.zero;
		itmeRB.AddForce (itmeYon,ForceMode2D.Impulse);

	}
}
