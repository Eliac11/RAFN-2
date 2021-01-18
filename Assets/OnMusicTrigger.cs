using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMusicTrigger : MonoBehaviour
{
    public AudioSource aaa;

    void OnCollisionEnter(Collision over)
    {
        if (over.gameObject.CompareTag("Player"))
        {
            aaa.Play();
        }
    }
}
