using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3Events : MonoBehaviour
{

    public GameObject player;
    public GameObject dummy;

    public int startspeed = 10;

    void Start()
    {
        player.SetActive(false);
        dummy.SetActive(true);

        dummy.GetComponent<Rigidbody>().AddForce(dummy.transform.forward * startspeed, ForceMode.Impulse);
        dummy.GetComponent<Rigidbody>().AddTorque(gameObject.transform.forward * 100);
    }

    private bool startwas = false;
    void Update()
    {
        if (!startwas)
        {
            if (dummy.GetComponent<Rigidbody>().velocity.magnitude == 0)
            {
                player.transform.position = new Vector3(dummy.transform.position.x,dummy.transform.position.y+20,dummy.transform.position.z);


                player.SetActive(true);
                dummy.SetActive(false);
                startwas = true;
            }
        }
    }

}
