using UnityEngine;
using System.Collections;

public class firlaticiKontrol : MonoBehaviour {

	public float mermiHiz;
	Rigidbody2D RB;
	void Awake(){
		RB=GetComponent<Rigidbody2D>();
		if(transform.localRotation.z>0)
			RB.AddForce(new Vector2(-1,0)*mermiHiz,ForceMode2D.Impulse);
		else
			RB.AddForce(new Vector2(1,0)*mermiHiz,ForceMode2D.Impulse);
	}



	// Update is called once per frame
	void Update () {

	}
	public void kuvvetKaldır(){
		RB.velocity = new Vector2 (0,0);
	}
}
