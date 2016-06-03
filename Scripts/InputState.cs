using UnityEngine;
using System.Collections;

public class InputState : MonoBehaviour {
	public float jumpSpeed = 240;
	public float forwardSpeed=20;

	//public bool actionButton;
	public float absVelX = 0;
	public float absVelY = 0;
	public bool standing;
	public float standingThreshold = 1;

	public Rigidbody2D _rbody2D;

	void Update () {
		//if (Input.GetMouseButtonDown (0)) {
			//transform.Translate(0,50,0);
		//}
	}
	void FixedUpdate(){
		
		//absVelX = System.Math.Abs (_rbody2D.velocity.x);
		//absVelY = System.Math.Abs (_rbody2D.velocity.y);

		//standing = absVelY <= standingThreshold;
	}
}
