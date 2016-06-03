using UnityEngine;
using System.Collections;

public class AnimateBackGround : MonoBehaviour {

	public Vector2 Speed=Vector2.zero;

	private  Vector2 _offset=Vector2.zero;
	private Material _material;

	// Use this for initialization
	void Start () {
		_material = GetComponent<Renderer> ().material;

		_offset = _material.GetTextureOffset ("_MainTex");
	}
	
	// Update is called once per frame
	void Update () {
		_offset += Speed * Time.deltaTime;

		_material.SetTextureOffset ("_MainTex",_offset);
	}
}
