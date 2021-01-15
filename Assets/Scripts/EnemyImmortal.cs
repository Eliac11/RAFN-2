using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyImmortal : MonoBehaviour
{
    public GameObject player;
    public float dist;
    NavMeshAgent nav;
    public float Radius = 70;
    void Start()
    {
        nav = GetComponent<NavMeshAgent> ();
    }

    void Update()
    {
        dist = Vector3.Distance (player.transform.position, transform.position);
        if(dist > Radius)
        { 
           nav.enabled = false;
           gameObject.GetComponent<Animator>().SetTrigger("Idle");
        }
        if(dist < Radius & dist>2f)
        {
            nav.enabled = true;
            nav.SetDestination(player.transform.position);
            gameObject.GetComponent<Animator>().SetTrigger("Run");
        }
        
        if(dist < 3f)
        {
            gameObject.GetComponent<Animator>().SetTrigger("Hit");
        }
    }
}
