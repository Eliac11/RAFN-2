using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour {

	public GameObject weapon1;
	public GameObject weapon2;
	public int selectedWeapon = 0;

	// Use this for initialization
	void Start () {
		weapon1.SetActive (true);
		weapon2.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {

		int previousSelectedWeapon = selectedWeapon;

		if (Input.GetAxis ("Mouse ScrollWheel") > 0f) 
		{
			if (selectedWeapon >= transform.childCount - 1)
				selectedWeapon = 0;
			else
			selectedWeapon++;
		}
		if (Input.GetAxis ("Mouse ScrollWheel") < 0f) 
		{
			if (selectedWeapon <= 0)
				selectedWeapon = transform.childCount - 1;
			else
				selectedWeapon--;
		}

		if (previousSelectedWeapon != selectedWeapon)
		{
			SelectWeapon ();
		}

		if (Input.GetKeyDown (KeyCode.Alpha1)) 
		{
			weapon1.SetActive (true);
			weapon2.SetActive (false);
		}
		if (Input.GetKeyDown (KeyCode.Alpha2)) 
		{
			weapon1.SetActive (false);
			weapon2.SetActive (true);
		}
	}
	void SelectWeapon(){
		int i = 0;
		foreach (Transform weapon in transform) {
			if (i == selectedWeapon)
				weapon.gameObject.SetActive (true);
			else
				weapon.gameObject.SetActive (false);
			i++;
		}
		}
	}
