using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorNoKey : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip Open;

    void OnTriggerEnter(Collider other)
    {
if (other.tag == "Player")
{
  OpenDoor(); 
}

}
    public void OpenDoor()
    {
        gameObject.GetComponent<Animator>().SetTrigger("Open");
        audio.PlayOneShot(Open);
    }
    
}
