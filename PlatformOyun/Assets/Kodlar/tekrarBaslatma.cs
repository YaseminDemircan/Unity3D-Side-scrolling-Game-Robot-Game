using UnityEngine;
using System.Collections;

public class tekrarBaslatma : MonoBehaviour {

	public float tekrarSure;
	bool simdiBasla=false;
	float resetSure;
	void Start () {
	
	}
	

	void Update () {
	      
		if (simdiBasla && resetSure <= Time.time) {
			Application.LoadLevel (Application.loadedLevel);
		}
	}
	public void yenidenBaslat(){
		simdiBasla = true;
		resetSure = Time.time + tekrarSure;
	}
}
