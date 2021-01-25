using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float HP = 1f;

    private bool isStartednewScene = false;
    void Start()
    {
        
    }

    void Update()
    {
        if (HP <= 0)
        {
            if (!isStartednewScene) { 
                //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                SceneLoader.StartScene(SceneManager.GetActiveScene().name);
                isStartednewScene = true; 
            }
        }
    }
     void OnTriggerEnter (Collider other)
    {
        if(other.tag == "EnemyHit")
        {
            HP = HP - 0.2f;
        }
    }
}
