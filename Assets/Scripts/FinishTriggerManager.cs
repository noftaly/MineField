using UnityEngine;
using System.Collections;

public class FinishTriggerManager : MonoBehaviour {

	public enum States {Progress, Won, Lose};

	public static int GameState = (int)States.Progress;

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter (Collider collider) { // When touching the cylinder
		if (collider.name == "Player" && GameState != (int)States.Lose) {
			Debug.Log ("Fin de la partie !");
			GameState = (int)States.Won;
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
