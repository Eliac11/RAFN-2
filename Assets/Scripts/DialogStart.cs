using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogStart : MonoBehaviour
{
    public GameObject DialogWindow;


    private bool DialogNachalo;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (DialogNachalo == false)
            {
                DialogWindow.SetActive (true);
                DialogNachalo = true;
            } else
            {
                DialogWindow.SetActive (false);
                DialogNachalo = false;
            }
        }
    }
}
