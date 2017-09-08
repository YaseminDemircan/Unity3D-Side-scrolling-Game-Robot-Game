using UnityEngine;
using System.Collections;

public class oyunKazanma : MonoBehaviour {

	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D nesne){
		if (nesne.tag == "Player") {
			oyuncuCan oyunKazan = nesne.gameObject.GetComponent<oyuncuCan> ();
			oyunKazan.kazan ();
		}
	}
}
