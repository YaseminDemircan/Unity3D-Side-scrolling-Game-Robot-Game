using UnityEngine;
using System.Collections;

public class mermiCarpma : MonoBehaviour {

	public float silahHasar;

	firlaticiKontrol FK;

	public GameObject patlamaEfekt;

	void Awake () {
		FK = GetComponentInParent<firlaticiKontrol> ();

	}


	void Update () {

	}

	void OnTriggerEnter2D(Collider2D nesne){
		if (nesne.gameObject.layer == LayerMask.NameToLayer ("Vurulabilir")) {
			FK.kuvvetKaldır();
			Instantiate (patlamaEfekt,transform.position,transform.rotation);
			Destroy (gameObject);
			if (nesne.tag == "Tuzak") {
				tuzakCan zararTuzak = nesne.gameObject.GetComponent<tuzakCan> ();
				zararTuzak.zararVer (silahHasar);
			}
		}
	}
	void OnTriggerStay2D(Collider2D nesne){
		if (nesne.gameObject.layer == LayerMask.NameToLayer ("Vurulabilir")) {
			FK.kuvvetKaldır ();
			Instantiate (patlamaEfekt,transform.position,transform.rotation);
			Destroy (gameObject);
			if (nesne.tag == "Tuzak") {
				tuzakCan zararTuzak = nesne.gameObject.GetComponent<tuzakCan> ();
				zararTuzak.zararVer (silahHasar);
			}
		}
	}
}
