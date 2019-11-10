using UnityEngine;
using System.Collections;

public class PlayerInit : MonoBehaviour {

	public Vector3 spawnpoint;

	void Start () {
		gameObject.transform.position = spawnpoint;
	}

}
