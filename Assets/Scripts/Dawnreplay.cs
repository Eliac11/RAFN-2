using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dawnreplay : MonoBehaviour
{
    void OnTriggerEnter(Collider over)
    {
        if (over.CompareTag("Player"))
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            SceneLoader.StartScene(SceneManager.GetActiveScene().name);
        }
    }
}
