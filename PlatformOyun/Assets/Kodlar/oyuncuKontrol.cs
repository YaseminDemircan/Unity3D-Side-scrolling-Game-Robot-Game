using UnityEngine;
using System.Collections;

public class oyuncuKontrol : MonoBehaviour {

	//yurume
	public float maxHiz;

	//zıplama
	bool yerde=false;
	float yerYaricap= 0.2f;
	public LayerMask yerLayer;
	public Transform yerCheck;
	public float ziplamaYukseklik;

	Rigidbody2D RB;
	Animator Anim;
	bool sagYuz; 

	//ates etme
	public Transform silahUcu;
	public GameObject kursun;
	float atesOran= 0.5f;
	float sonrakiAtes= 0f;

	void Start () {

		RB = GetComponent<Rigidbody2D> ();
		Anim = GetComponent<Animator> ();
		sagYuz = true;
	}
	void Update(){
		if (yerde && Input.GetAxis ("Jump") > 0) {
			yerde = false;
			Anim.SetBool ("yerdeMi", yerde);
			RB.AddForce (new Vector2 (0, ziplamaYukseklik));
		}
		//karakterin ates etmesi
		if (Input.GetAxisRaw ("Fire1") > 0)
			atesEt ();

	}

	// Update is called once per frame
	void FixedUpdate () {

		//yerde mi
		yerde=Physics2D.OverlapCircle(yerCheck.position,yerYaricap,yerLayer);
		Anim.SetBool ("yerdeMi",yerde);

		Anim.SetFloat ("duseyHiz",RB.velocity.y);

		float hareket = Input.GetAxis ("Horizontal");
		Anim.SetFloat ("hiz",Mathf.Abs(hareket));

		RB.velocity = new Vector2 (hareket*maxHiz,RB.velocity.y);

		if (hareket > 0 && !sagYuz) {
			cevir ();
		}
		else if (hareket<0 && sagYuz) {
			cevir();
		}

	}
	void cevir()
	{
		sagYuz = !sagYuz;
		Vector3 yon = transform.localScale;
		yon.x *= -1;
		transform.localScale = yon;
	}
	void atesEt(){
		if (Time.time > sonrakiAtes) {
			sonrakiAtes = Time.time + atesOran;
			if (sagYuz) {
				Instantiate(kursun, silahUcu.position, Quaternion.Euler (new Vector3 (0, 0, 0)));
			} else if (!sagYuz) {
				Instantiate(kursun, silahUcu.position, Quaternion.Euler (new Vector3 (0, 0, 180f)));
			}
		}
	}
}
