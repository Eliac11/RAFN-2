using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PewPew : MonoBehaviour
{
public Rigidbody bullet;
public Transform gunPoint;
public float bulletSpeed = 10;
public float timeout = 0.5f;
public ParticleSystem vistrel;

	public int maxBulletinShop = 6;


	private int BulletInShop;
	private bool canfire = true;

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
		
				if (canfire)
				{
					if (BulletInShop > 0)
					{
						Fire();
						BulletInShop -= 1;
						canfire = false;
					}
				}
		
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
			vistrel.Play();
			audio.PlayOneShot(audio.clip);
			
			Rigidbody bulletInstance = Instantiate(bullet, gunPoint.position, Quaternion.identity) as Rigidbody;
			bulletInstance.velocity = gunPoint.forward * bulletSpeed;
	}


	//если короче эта функция вызывается в анимации
	public void Recharge()
	{
		BulletInShop = maxBulletinShop;
		canfire = true;
	}
	public void makeCanFire()
	{
		canfire = true;
	}

}
