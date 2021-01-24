using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diag_Start : MonoBehaviour
{
    public bool enddial;
    public GameObject dial1;

    void Update()
    {
        if (enddial == true)
        {
            dial1.SetActive (false);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            dial1.SetActive (true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            dial1.SetActive (false);
        }
    }
}
