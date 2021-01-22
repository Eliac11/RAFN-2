using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnScriptTrigger : MonoBehaviour {
	
	public UpPaper paperScript;
	public GameObject TextUp;
	public GameObject Paper;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player") {
			TextUp.SetActive (true);
			paperScript.enabled = true;
		}
	}
	void OnTriggerExit(Collider col)
	{
		if (col.tag == "Player") {
			Paper.SetActive (false);
			TextUp.SetActive (false);
			paperScript.enabled = false;
		}
	}
}
