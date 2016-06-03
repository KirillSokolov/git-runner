using UnityEngine;
using System.Collections;

public class SoundOff : MonoBehaviour {
    public int off=0;//0 off 1 On
    public GameObject Off;
    public GameObject On;
    public GameObject Seting;
    public GameObject Menu;
    public GameObject Planet;
    public GameObject Stars;

    public void OnSound()
    {
        Off.SetActive(true);
        On.SetActive(false);
        off = 0;
    }
    public void OffSound()
    {
        On.SetActive(true);
        Off.SetActive(false);
     //   this.gameObject.SetActive(false);
        off = 1;
    }
    public void Save()
    {
        PlayerPrefs.SetInt("Sound", off);
        Seting.SetActive(false);
        Stars.SetActive(true);
        Planet.SetActive(true);
        Menu.SetActive(true);
    }
    public void Quit()
    {
        Seting.SetActive(false);
        Stars.SetActive(true);
        Planet.SetActive(true);
        Menu.SetActive(true);
    }
    public void SetingMenu()
    {
        Seting.SetActive(true);
        Stars.SetActive(false);
        Planet.SetActive(false);
        Menu.SetActive(false);


    }

}
