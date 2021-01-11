using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doorKey : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip Open;

    void OnTriggerEnter(Collider other)
    {
if (other.tag == "Player")
{
    if (other.GetComponent<KeyControl>().KeyHas == true)
    {
        OpenDoor();
    }
}
    }
    public void OpenDoor()
    {
        gameObject.GetComponent<Animator>().SetTrigger("Open");
        audio.PlayOneShot(Open);
    }
    
}
