using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongsGroza : MonoBehaviour
{

    public AudioClip[] grozasSongs;
    private AudioSource sors; 
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        sors = GetComponent<AudioSource>();
    }

    public void PlayGroza()
    {
        anim.SetTrigger("udar");
        sors.clip = grozasSongs[Random.Range(0, grozasSongs.Length)];
        sors.Play();
    }

    
}
