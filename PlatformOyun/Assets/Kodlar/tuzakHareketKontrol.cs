using UnityEngine;
using System.Collections;

public class tuzakHareketKontrol : MonoBehaviour {

	public float tuzakHiz;

	Animator tuzakAnimator;

	public GameObject tuzakGrafik;
	bool canFlip=true;
	bool sagYuz=false;
	float cevirSure=5f;
	float sonrakicevirme=0f;

	//saldırma
	public float gorevSure;
	float baslaGorevSure;
	bool robot;
	Rigidbody2D tuzakRB;

	void Start () {
		tuzakAnimator = GetComponentInChildren<Animator> ();
		tuzakRB = GetComponent<Rigidbody2D> ();

	}

	// Update is called once per frame
	void Update () {
		if (Time.time > sonrakicevirme) {
			if (Random.Range (0, 10) >= 5)
				cevirYuz();
			sonrakicevirme = Time.time + cevirSure;
		}

	}
	void OnTriggerEnter2D(Collider2D nesne){
		if (nesne.tag == "Player") {
			if (sagYuz && nesne.transform.position.x < transform.position.x) {
				cevirYuz ();
			}
			else if(!sagYuz && nesne.transform.position.x > transform.position.x){
				cevirYuz ();
			}
			canFlip = false;
			robot = true;
			baslaGorevSure= Time.time + gorevSure;
		}
	}
	void OnTriggerStay2D(Collider2D nesne){
		if (nesne.tag == "Player") {
			if (baslaGorevSure < Time.time) {
				if (!sagYuz)
					tuzakRB.AddForce (new Vector2(-1,0)*tuzakHiz);
				else 
					tuzakRB.AddForce (new Vector2(1,0)*tuzakHiz);
				tuzakAnimator.SetBool ("robot",robot);
			}
		}
	}
	void OnTriggerExit2D(Collider2D nesne){
		if (nesne.tag == "Player") {
			canFlip = true;
			robot = false;
			tuzakRB.velocity = new Vector2 (0f,0f);
			tuzakAnimator.SetBool ("robot",robot);
		}
	}

	void cevirYuz(){
		if (!canFlip)
			return;
		float facingX = tuzakGrafik.transform.localScale.x;
		facingX *= -1f;
		tuzakGrafik.transform.localScale = new Vector3 (facingX,tuzakGrafik.transform.localScale.y,tuzakGrafik.transform.localScale.z);
		sagYuz = !sagYuz;
	}
}
