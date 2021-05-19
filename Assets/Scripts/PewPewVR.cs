using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class PewPewVR : MonoBehaviour
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

private SteamVR_Input_Sources inhand;

	public void OnAttachedToHand( Hand hand )
	{
		inhand = hand.handType;
		//Debug.Log(hand.handType.ToString() == "LeftHand");
	}
	void Start()
{
	hahanimator = GetComponent<Animator>();
	audio = GetComponent<AudioSource>();


		BulletInShop = maxBulletinShop;
	}


	


	void Update() 
{
	if(SteamVR_Actions._default.Fire.GetStateDown(inhand))
	{
				if (canfire)
				{
						FireVR();
						canfire = false;
				}
	}

		//if (Input.GetKey(KeyCode.R))
		//{
		//	if (BulletInShop != maxBulletinShop)
		//	{
		//		hahanimator.SetTrigger("Recharge");
		//	}
		//}
}

	void FireVR()
	{
			hahanimator.SetTrigger("FIRE");
			vistrel.Play();
			audio.PlayOneShot(audio.clip);
			
			Rigidbody bulletInstance = Instantiate(bullet, gunPoint.position, Quaternion.identity) as Rigidbody;
			bulletInstance.velocity = gunPoint.forward * bulletSpeed;
	}


	//если короче эта функция вызывается в анимации
	//public void Recharge()
	//{
	//	BulletInShop = maxBulletinShop;
	//	canfire = true;
	//}
	public void makeCanFireendAnimation()
	{
		canfire = true;
	}

}
