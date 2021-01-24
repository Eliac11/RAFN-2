using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialSwitch : MonoBehaviour
{
    public GameObject line1;
    public GameObject line2;
    public GameObject line3;
    public GameObject line4;
    public Diag_Start dialogScript;

    private bool NowLine1 = true;
    private bool NowLine2 = false;
    private bool NowLine3 = false;
    private bool NowLine4 = false;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            if (NowLine1 == true)
            {
                NowLine1 = false;
                NowLine2 = true;
            }else if(NowLine2 == true)
            {
                NowLine2 = false;
                NowLine3 = true;
            }else if(NowLine3 == true)
            {
                NowLine3 = false;
                NowLine4 = true;
            }else if(NowLine4 == true)
            {
                NowLine4 = false;
                NowLine1 = true;
                dialogScript.enddial = true;
            }
        }
        if(NowLine1 == true)
        {
            line1.SetActive (true);
            line2.SetActive (false);
            line3.SetActive (false);
            line4.SetActive (false);
        }else if(NowLine2 == true)
        {
            line1.SetActive (false);
            line2.SetActive (true);
        } else if(NowLine3 == true)
        {
            line2.SetActive (false);
            line3.SetActive (true);
        } else if(NowLine4 == true)
        {
            line3.SetActive (false);
            line4.SetActive (true);
        }
    }
}