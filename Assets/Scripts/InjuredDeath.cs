using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InjuredDeath : MonoBehaviour
{
    public GameObject Injured;
    public GameObject Ragdoll;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Injured.SetActive (false);
            Ragdoll.SetActive (true);
        }
    }
}
