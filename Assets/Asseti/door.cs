using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door : MonoBehaviour
{
    public AudioSource _audio;
    public AudioClip OpenSFX;
    public Animator _anim;

    //private void Start()
    //{
       // _anim = GetComponent<Animator>();
    //}
     void OnTriggerEnter(Collider other)
    {
if (other.tag == "Player")
{
    if (other.GetComponent<KeyControl>().KeyHas == true)
    {
        SceneManager.LoadScene(0);
    }
}
    }
    
   //public void OpenDoor()    не работает,исправить
   //{
       ////_anim.Play("Open");
      // _audio.PlayOneShot(OpenSFX);
  // }
}
