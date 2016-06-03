using UnityEngine;
using System.Collections;

public class Enviroment : MonoBehaviour,IRecyle {
	public Sprite[] sprites;
	public BoxCollider2D[] col2d; 
	int _numbersprite;
	float y;
	public void Restart(){
		var renderer = GetComponent<SpriteRenderer> ();
		_numbersprite = Random.Range (0, sprites.Length);
		renderer.sprite = sprites [_numbersprite];
		col2d [_numbersprite].enabled = true;
		transform.position += new Vector3 (0,-10.5f, 0);
		switch (_numbersprite) {
		case 0:
			y=-18.6f;
			transform.localScale = new Vector3 (12, 12, 1);
			//transform.localScale.y = 12f;
			//transform.position=y;
			break;
		case 1:
			transform.localScale = new Vector3 (15, 15, 1);

			break;
		case 2:
			transform.localScale = new Vector3 (14, 14, 1);
			break;


		case 3:
			transform.localScale = new Vector3 (12, 12, 1);
			break;
		case 4:
			transform.localScale = new Vector3 (30, 30, 1);
			break;

		case 5:
			transform.localScale = new Vector3 (30, 30, 1);

			break;
		case 6:
			transform.localScale = new Vector3 (30, 30, 1);
			break;
	
		}
		//var collider = GetComponent<BoxCollider2D> ();
		//collider.size = renderer.bounds.size;
	}
	public void ShutDown(){
	}
}
