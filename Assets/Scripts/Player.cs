using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float HP = 1f;
    void Start()
    {
        
    }

    void Update()
    {
        if (HP <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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
