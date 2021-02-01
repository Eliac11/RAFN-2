using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadioPodbor : MonoBehaviour
{
    public Text txt;
    public string RadioText;
    public GameObject Radio;

    public GameObject textpro;

    private bool RadioPod;


    void Start()
    {
        textpro.GetComponent<TMPro.TextMeshPro>().text = RadioText;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (RadioPod == false)
            {
                Radio.SetActive (true); //нажал -- появилось
                txt.text = null;
                txt.text = RadioText;
                RadioPod = true;
            } else
            {
                Radio.SetActive (false);
                txt.text = null;  // если еще раз нажал,то пропадает
                RadioPod = false;
            }
        }
    }
}