using UnityEngine;
using System.Collections;

public class DestroyOffScreen : MonoBehaviour {
	
	public float offset = 16;

	private bool offscreen;
	private float offscreenX=0;
	private Rigidbody2D _rbody2d;

	void Awake () {
		_rbody2d = GetComponent<Rigidbody2D > ();
	}

	void Start()
	{
		offscreenX = (Screen.width / PixelPerfectCamera.pixelToUnits);
	}
	
	void Update () {
		var posX = transform.position.x;
		var dirX = _rbody2d.velocity.x;

		if (Mathf.Abs (posX) > offscreenX) {
			if (dirX < 0 && posX < -offscreenX) {
				offscreen = true;
			} else if (dirX > 0 && posX > offscreenX) {
				offscreen = false;
			}

		} else {
			offscreen = false;
		}
		if (offscreen) {
			OnOutOfBounds ();
		}
			
	}
	public void OnOutOfBounds(){
		offscreen = false;
		GameObjectUtil.Destroy (gameObject);
	}
}
