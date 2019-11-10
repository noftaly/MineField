/**/
using UnityEngine;

public class CheatTest : MonoBehaviour {

	private MeshRenderer mesh;

	// Use this for initialization
	void Start () {
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			for (int i = 0; i < SpawnObject.objectsPopped.Length; i++) {
				mesh = SpawnObject.objectsPopped[i].GetComponent<MeshRenderer> ();
				mesh.enabled = !mesh.enabled;
			}
		}
	}
}
/**/