using UnityEngine;
using System.Collections;

public class MineWarningTriggerManager : MonoBehaviour {

	public AudioClip sound; // Récupère le son
	AudioSource audio; // (privé) Permet de manipuler l'objet associé
	bool soundIsPlaying;
	bool isInWarningZone;
	Vector3 warningOffset;
	Vector3 warningOffsetMax;

	void Start () {
		audio = GetComponent<AudioSource> ();
		audio.volume = 1000;
		warningOffset.Set(-1, -1, -1);
		isInWarningZone = false;
	}

	void OnTriggerEnter (Collider collider) { // Quand on entre dans la zone d'avertissement
		isInWarningZone = true;

		warningOffsetMax = transform.position - collider.transform.position;
		if (FinishTriggerManager.GameState == (int)FinishTriggerManager.States.Progress) audio.PlayOneShot (sound);

	}

	void OnTriggerStay(Collider collider) {
		warningOffset = transform.position - collider.transform.position;
		float playDelay = warningOffset.magnitude / warningOffsetMax.magnitude;
		playDelay *= playDelay;
	
		//audio.volume = playDelay + 5;
		if (collider.gameObject.name == "Player" && !soundIsPlaying) {
			soundIsPlaying = true;
			Invoke ("PlayWarningSound", playDelay);
		}
	}

	void OnTriggerLeave(Collider collider) {
		isInWarningZone = false;
	}

	void PlayWarningSound() {
		if (isInWarningZone && FinishTriggerManager.GameState == (int)FinishTriggerManager.States.Progress) {
			audio.PlayOneShot (sound);
			soundIsPlaying = false;
		}
	}

	void Update () {
	
	}
}
