using UnityEngine;
using System.Collections;

public class sporAt : MonoBehaviour {

	public GameObject mermi;
	public float atisSure;
	public int sansAtis;
	public Transform atilanYer;

	float sonrakiAtisSure;
	Animator bitkiAnim;
	void Start () {

		   bitkiAnim = GetComponentInChildren<Animator> ();
		   sonrakiAtisSure = 0f;
	}


	void Update () {

	}
	void OnTriggerStay2D(Collider2D nesne){
		if (nesne.tag == "Player" && sonrakiAtisSure < Time.time) {
			sonrakiAtisSure = Time.time + atisSure;
			if (Random.Range (0, 10) >= sansAtis) {
				Instantiate (mermi,atilanYer.position,Quaternion.identity);
			    bitkiAnim.SetTrigger ("saldiri");
			}
		}
	}
}
