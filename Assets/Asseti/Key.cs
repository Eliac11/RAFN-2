using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public AudioSource PickupSFX;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<KeyControl>().KeyHas = true;
            PickupSFX.Play();
            Destroy(gameObject, 1);
        }
    }
}
