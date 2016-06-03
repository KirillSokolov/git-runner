using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {
	public GameObject Shop;
	public GameObject Scroll;
	public GameObject Play;
	public GameObject Plus;
	public GameObject Seting;
	// Use this for initialization
	public void StartShop () {
		Shop.SetActive (true);
		OffMainMenu ();
	}
	
	// Update is called once per frame
	public void OffMainMenu () {
		Scroll.SetActive (false);
		Play.SetActive (false);
		Seting.SetActive (false);
		Plus.SetActive (false);
	}
	public void OnMainMenu () {
		Scroll.SetActive (true);
		Play.SetActive (true);
		Seting.SetActive (true);
		Plus.SetActive (true);
	}
}
