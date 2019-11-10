using UnityEngine;
using System.Collections;

public class SpawnObject : MonoBehaviour {

	public GameObject objectPop = null; // = Objet à faire apparaître
	public Vector3 popZone; // = Zone d'apparition
	public static int maxPop = 10; // = Nb max d'objets
	public static GameObject[] objectsPopped = new GameObject[maxPop];
	int i = 0;

	void Start () {
	
	}
	
	void Update () {
		Vector3 pop;

		if (objectPop != null && i < maxPop) {
			pop.x = Random.Range (0, popZone.x);
			pop.y = popZone.y;
			pop.z = Random.Range (0, popZone.z);
			// Création objet mine (objectPop), à la position pop, avec la rotation objectPop.transform.rotation :
			//Instantiate (objectPop, pop, objectPop.transform.rotation);
			objectsPopped [i] = (GameObject)Instantiate (objectPop, pop, objectPop.transform.rotation);
			i++;
		}
	}
}
