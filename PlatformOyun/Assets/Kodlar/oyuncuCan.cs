using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class oyuncuCan: MonoBehaviour {

	public float maxCan;
	public GameObject olmeEfekti;

	float simdikiCan;

    oyuncuKontrol kontrolHareket;

	//HUD variables
	public Slider canSlider;
	public tekrarBaslatma oyunYonetici;




	void Start () {
		simdikiCan = maxCan;
		kontrolHareket = GetComponent<oyuncuKontrol> ();

		//HUD initilization
		canSlider.maxValue=maxCan;
		canSlider.value = maxCan;


	}

	// Update is called once per frame
	void Update () {


	}
	public void zararVer(float zarar){
		if (zarar <= 0)
			return;
		simdikiCan -= zarar;
		canSlider.value = simdikiCan;



		if (simdikiCan <= 0) {
			oldur ();
		}
	}
	public void canEkle(float canSayisi){
		simdikiCan += canSayisi;
		if (simdikiCan > maxCan)
			simdikiCan = maxCan;
		canSlider.value = simdikiCan;

	}
	public void oldur(){
		Instantiate (olmeEfekti,transform.position,transform.rotation);
		Destroy (gameObject);
		oyunYonetici.yenidenBaslat ();


	}
	public void kazan(){
		Destroy (gameObject);
		oyunYonetici.yenidenBaslat ();
	}
}
