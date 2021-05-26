using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySongs : MonoBehaviour
{
    public AudioClip Take;
    public AudioClip Drop;
    private AudioSource audiosorse;
    void Start()
    {
        audiosorse = GetComponent<AudioSource>();
    }
    public void playTake(){
        audiosorse.clip = Take;
        audiosorse.Play();
    }
    public void playDrop(){
        audiosorse.clip = Drop;
        audiosorse.Play();
    }
    
}
