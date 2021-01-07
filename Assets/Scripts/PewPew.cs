using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PewPew : MonoBehaviour
{
public Rigidbody bullet;
public Transform gunPoint;
public float bulletSpeed = 10;
public float timeout = 0.5f;

	public int maxBulletinShop = 6;


	private int BulletInShop;
private float curTimeout;
Animator hahanimator;
private AudioSource audio;

void Start()
{
	hahanimator = GetComponent<Animator>();
	audio = GetComponent<AudioSource>();


		BulletInShop = maxBulletinShop;
	}


 void Update() 
{
	if(Input.GetMouseButton(0))
	{
		curTimeout += Time.deltaTime;
		if(curTimeout > timeout)
		{
				if (BulletInShop > 0)
				{
					curTimeout = 0;
					Fire();
					BulletInShop -= 1;
				}
		}
	}
	else 
	{
		curTimeout = timeout + 1;
	}



		if (Input.GetKey(KeyCode.R))
		{
			if (BulletInShop != maxBulletinShop)
			{
				hahanimator.SetTrigger("Recharge");
			}
		}
}

	void Fire()
	{
			hahanimator.SetTrigger("Shoot");
			audio.PlayOneShot(audio.clip);
			
			Rigidbody bulletInstance = Instantiate(bullet, gunPoint.position, Quaternion.identity) as Rigidbody;
			bulletInstance.velocity = gunPoint.forward * bulletSpeed;
	}


	//если короче эта функция вызывается в анимации
	public void Recharge()
	{
		BulletInShop = maxBulletinShop;
	}

}
