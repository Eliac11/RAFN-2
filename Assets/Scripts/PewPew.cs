using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PewPew : MonoBehaviour
{
public Rigidbody bullet;
public Transform gunPoint;
public float bulletSpeed = 10;
public float timeout = 0.5f;

private float curTimeout;
Animator hahanimator;
private AudioSource audio;

void Start()
{
	hahanimator = GetComponent<Animator>();
	audio = GetComponent<AudioSource>();
}

 void Update() 
{
	if(Input.GetMouseButton(0))
	{
		curTimeout += Time.deltaTime;
		if(curTimeout > timeout)
		{
			hahanimator.SetTrigger("Shoot");
			audio.PlayOneShot(audio.clip);
			curTimeout = 0;
			Rigidbody bulletInstance = Instantiate(bullet, gunPoint.position, Quaternion.identity) as Rigidbody;
			bulletInstance.velocity = gunPoint.forward * bulletSpeed;	
		}
	}
	else 
	{
		curTimeout = timeout + 1;
	}
}
}
