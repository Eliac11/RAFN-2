using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doorKey : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip Open;

    public bool isneedKey = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (isneedKey)
            {
                if (other.GetComponent<KeyControl>().KeyHas == true)
                {
                    OpenDoor();

                }
            }
            else
            {
                OpenDoor();
            }
}

}
    public void OpenDoor()
    {
        gameObject.GetComponent<Animator>().SetTrigger("Open");
        
    }
    

    //приятно что ты решил заглянуть в этот скрипт ))
    //вообщем эта фф вызывается из анимации
    // блин щас русский начнется, а я хз какая у нас тема 
    public void playaudioOpen()
    {
        audio.PlayOneShot(Open);
    }

}
