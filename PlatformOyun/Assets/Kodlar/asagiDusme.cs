using UnityEngine;
using System.Collections;

public class asagiDusme : MonoBehaviour {


	void Start () {
		Physics2D.IgnoreLayerCollision (LayerMask.NameToLayer("Vurulabilir"),LayerMask.NameToLayer("Vurulabilir"));
	
	}
	

	void Update () {
	
	}
}
