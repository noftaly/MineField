using UnityEngine;
using System.Collections;

public class CameraManager : MonoBehaviour {
	
	public GameObject player;
	private Vector3 offset;

	void Awake () {
		offset = transform.position - player.transform.position;
	}

	// (Update after calculation, often use for cameras)
	void LateUpdate () {
		if (FinishTriggerManager.GameState == (int)FinishTriggerManager.States.Progress) {
			transform.position = player.transform.position + offset;
		}
	}
}
