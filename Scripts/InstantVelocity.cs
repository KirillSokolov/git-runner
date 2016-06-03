using UnityEngine;
using System.Collections;

public class InstantVelocity : MonoBehaviour {

	public Vector2 velocity = Vector2.zero;

	private Rigidbody2D _rbody2d;
	// Use this for initialization
	void Awake () {
		_rbody2d = GetComponent<Rigidbody2D > ();
	
	}
	
	// Update is called once per frame
	void Update () {
		_rbody2d.velocity = velocity;
	}
}
