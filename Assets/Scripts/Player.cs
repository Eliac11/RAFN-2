﻿using System.Collections;
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
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                isStartednewScene = true; 
            }
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Escape pressed!");
        }
    }
     void OnTriggerEnter (Collider other)
    {
        if(other.tag == "EnemyHit")
        {
            HP = HP - 0.2f;
        }
        if(other.tag == "Dead")
        {
            HP = HP - 1f;
        }
    }
}
