using UnityEngine;
using System.Collections;

public class bitirici : MonoBehaviour {

	void Start(){

	}

	void Update(){

	}

	void OnTriggerEnter2D(Collider2D nesne) {

		if(nesne.tag=="Player"){

			oyuncuCan oyuncuDusme=nesne.GetComponent<oyuncuCan>();

			oyuncuDusme.oldur();

		}

		else

			Destroy(nesne.gameObject);

	}
}
