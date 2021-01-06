using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    public GameObject bullet;

    void Update()
    {
      Destroy(gameObject, 2);  
    }
}
