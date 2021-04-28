using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    public float dist;
    NavMeshAgent nav;
    public float Radius = 15;
    public float HP = 100;
    public GameObject Ragdoll;
	public bool canattack = true;
    void Start()
    {
        nav = GetComponent<NavMeshAgent> ();
    }
	public void SetCanattack()
	{
	canattack = true;
	}

    void Update()
    {
        if(HP <= 0)
        {
            Instantiate(Ragdoll,transform.position, transform.rotation);
            Destroy (gameObject);
        }

        dist = Vector3.Distance (player.transform.position, transform.position);
        if(dist > Radius)
        { 
           nav.enabled = false;
           gameObject.GetComponent<Animator>().SetTrigger("Idle");
canattack = true;
        }
        if(dist < Radius & dist>2f)
        {
            nav.enabled = true;
            nav.SetDestination(player.transform.position);
            gameObject.GetComponent<Animator>().SetTrigger("Run");
        }
        
        if(dist < 2f)
        {
	if(canattack){
            gameObject.GetComponent<Animator>().SetTrigger("Attack");
		canattack=false;
		}
        }
    }
       void OnTriggerEnter (Collider other)
     {
       if (other.tag == "Bullet")
      {
          HP = HP - 25;
     }
     if (other.tag == "BulletR")
      {
          HP = HP - 100;
     }
        }
        void OnTriggerStay (Collider other)
    {
        if(other.tag=="Dead")
        {
            HP -=Time.deltaTime/10f;
        }
    }
}
