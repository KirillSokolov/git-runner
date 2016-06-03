using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	public GameObject prefabs;
	public float delay = 2;
	public bool active = true;
	public Vector2 delayRange = new Vector2 (1,2);

	void Start () {
		ResetDelay ();
		StartCoroutine(EnemyGenerator());
	}
	
	IEnumerator EnemyGenerator () {
		yield return new WaitForSeconds (delay);

		if (active) {
			var newTransform = transform;

			GameObjectUtil.Instantiate(prefabs,newTransform.position);
		}
		ResetDelay ();
		StartCoroutine(EnemyGenerator());
	}
	void ResetDelay(){
		delay = Random.Range (delayRange.x,delayRange.y);
	}

}
