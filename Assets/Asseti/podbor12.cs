using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class podbor12 : MonoBehaviour {

	public float distans = 2f;
	public GameObject SawedOff;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.E)) 
		{
			Ray ray = Camera.main.ScreenPointToRay (new Vector2 (Screen.width / 2, Screen.height / 2));
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit, distans)) 
			{
				if (hit.collider.GetComponent<pod12>()) {
					pod12 podb = hit.collider.GetComponent<pod12> ();
					SawedOff.SetActive (true);
					Destroy (podb.gameObject);

				}
			}
		}
	}
}
