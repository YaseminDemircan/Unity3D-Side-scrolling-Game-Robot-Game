using UnityEngine;
using System.Collections;

public class tuzakCan : MonoBehaviour {

	public float tuzakMaxCan;

	public bool dusme;
	public GameObject dusus;

	float simdikiCan;

	void Start () {

		simdikiCan = tuzakMaxCan;
	}


	void Update () {

	}

	public void zararVer(float zarar){
		simdikiCan -= zarar;
		if (simdikiCan <= 0)
			oldur ();
	}
	void oldur(){
		Destroy (gameObject.transform.parent.gameObject);

		if (dusme)
			Instantiate (dusus,transform.position,transform.rotation);
	}
}
