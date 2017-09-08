using UnityEngine;
using System.Collections;

public class yokEt : MonoBehaviour {

	public float hareketSuresi;
	void Awake(){
		Destroy(gameObject,hareketSuresi);
	}



	void Update () {

	}
}
