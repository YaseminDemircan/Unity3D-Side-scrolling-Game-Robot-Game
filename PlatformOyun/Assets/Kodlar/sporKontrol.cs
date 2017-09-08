using UnityEngine;
using System.Collections;

public class sporKontrol : MonoBehaviour {

	public float sporHizYuksek;
	public float sporHizAlcak;
	public float sporAci;
	public float sporTorkAci;

	Rigidbody2D sporRB;

	void Start () {
		sporRB = GetComponent<Rigidbody2D> ();
		sporRB.AddForce (new Vector2(Random.Range(-sporAci,sporAci),Random.Range(sporHizAlcak,sporHizYuksek)),ForceMode2D.Impulse);
		sporRB.AddTorque ((Random.Range(-sporTorkAci,sporTorkAci)));
	}


	void Update () {

	}
}
