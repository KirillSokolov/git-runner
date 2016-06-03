using UnityEngine;
using System.Collections;

public class MoveWay : MonoBehaviour {
	public Transform Way;
	public Transform Ground;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Ground.Translate (-20*Time.deltaTime,0,0);
		Way.Translate (-50*Time.deltaTime,0,0);
	}
}
