using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class m3 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
        SceneLoader.StartScene("Level4");
        }
    }
}
