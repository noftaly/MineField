using UnityEngine;
using System.Collections;

public class MineTriggerManager : MonoBehaviour {

	private ParticleSystem explosion;

	void Start () {
		explosion = GetComponent<ParticleSystem> ();

		if (explosion.isPlaying) explosion.Stop ();
	}

	void OnTriggerEnter (Collider collider) { // When entering in the explosion zone
		if (FinishTriggerManager.GameState == (int)FinishTriggerManager.States.Progress && collider.name == "Player") {
			Destroy (collider.GetComponent<MeshRenderer> ());
			FinishTriggerManager.GameState = (int)FinishTriggerManager.States.Lose;
			if (!explosion.isPlaying) explosion.Play ();
		}

	}

	void Update () {
		if (FinishTriggerManager.GameState == (int)FinishTriggerManager.States.Won) {
			if (!explosion.isPlaying) {
				explosion.Play ();
			}
		}
	}
}
