using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class podbor : MonoBehaviour {

	public float distans = 2f;
	public GameObject pistol;

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
				if (hit.collider.GetComponent<pod>()) {
					pod podb = hit.collider.GetComponent<pod> ();
					pistol.SetActive (true);
					Destroy (podb.gameObject);

	}
}
		}
	}
}
