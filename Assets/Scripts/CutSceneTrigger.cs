using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneTrigger : MonoBehaviour
{
    public GameObject CutScene;
    public GameObject Player;
    public GameObject CCamera;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            CutScene.SetActive (true);
            CCamera.SetActive (true);
            Player.SetActive (false);
        }
    }
}
