using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogSwitch : MonoBehaviour
{
public GameObject window1;
public GameObject window2;
public DialogStart dialogScript;
private bool win1a;
private bool win2a;

    void Update()
    {
        if (dialogScript.enabled = true){
        if (win2a == true)
            {
                window2.SetActive(true);
            }
        if (win1a == true)
            {
                window1.SetActive(true);
            }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            win1a=false;
            window1.SetActive(false);
            win2a=true;
        }
        }
    }
}
