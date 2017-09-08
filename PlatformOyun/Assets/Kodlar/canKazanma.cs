using UnityEngine;
using System.Collections;

public class canKazanma : MonoBehaviour {

	public float canSayisi;
	void Start () {

	}


	void Update () {

	}
	void OnTriggerEnter2D(Collider2D nesne){
		if (nesne.tag == "Player") {
			oyuncuCan can = nesne.gameObject.GetComponent<oyuncuCan> ();
			can.canEkle(canSayisi);
			Destroy (gameObject);
		}
	}
}
