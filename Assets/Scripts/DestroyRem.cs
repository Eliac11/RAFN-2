using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyRem : MonoBehaviour
{
    public GameObject rem;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MainCamera")
        {
            Destroy(gameObject);
        }
    }
}
