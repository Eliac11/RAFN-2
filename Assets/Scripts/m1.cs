﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class m1 : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneLoader.StartScene("Level2");
        }
    }
}
