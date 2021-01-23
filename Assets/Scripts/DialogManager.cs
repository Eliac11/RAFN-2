using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public GameObject DialogWindow;
    public DialogStart dialogScript;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            dialogScript.enabled = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            DialogWindow.SetActive (false);
            dialogScript.enabled = false;
        }
    }
}
