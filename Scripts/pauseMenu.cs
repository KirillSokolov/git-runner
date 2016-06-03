using UnityEngine;
using System.Collections;

public class pauseMenu : MonoBehaviour
{
	//public MoveBacground[] move;
    public GameObject pause;
    // Use this for initialization
    void Start()
    {
		Time.timeScale = 1;
        pause.SetActive(false);
    }
    public void Pause()
    {
        Time.timeScale = 0;
        pause.SetActive(true);
	//	move [0].enabled = false;
	//	move [1].enabled = false;
    }
    // Update is called once per frame
    void Update()
    {

    }
    public void Resume()
    {
        Time.timeScale = 1;
        pause.SetActive(false);
	//	move [0].enabled = true;
	//	move [1].enabled = true;
    }
    public void Menu()
    {
        Time.timeScale = 1;
        Application.LoadLevel(0);
    }
    public void Restart()
    {
        Time.timeScale = 1;
        Application.LoadLevel(1);
    }
}