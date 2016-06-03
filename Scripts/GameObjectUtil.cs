using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameObjectUtil  {

	private static Dictionary<RecycleGameObject,ObjectPool> pools = new Dictionary<RecycleGameObject,ObjectPool> ();

	public static GameObject Instantiate (GameObject pref, Vector3 pos){
		GameObject instance = null;

		var recyleScript = pref.GetComponent<RecycleGameObject> ();
		if (recyleScript != null) {
			var pool = GetObjectPool (recyleScript);
			instance = pool.NextObject (pos).gameObject;
		} else {

			instance = GameObject.Instantiate (pref);
			instance.transform.position = pos;
		}
		return instance;
	}

	public static void Destroy(GameObject _gameObject){
		var recyleGameObj = _gameObject.GetComponent<RecycleGameObject> ();
		//if (!recyleGameObj == null) {
			recyleGameObj.ShutDown ();
	//	}
		//else
		//GameObject.Destroy (_gameObject);
	}

	private static ObjectPool GetObjectPool (RecycleGameObject reference){
		ObjectPool pool = null;

		if (pools.ContainsKey (reference)) {
			pool = pools [reference];
		} else {
			var poolContainer=new GameObject(reference.gameObject.name+"ObjectPool");
			pool = poolContainer.AddComponent<ObjectPool> ();
			pool.prefab = reference;
			pools.Add (reference, pool);

		}
		return pool;

		
	}

}
