using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioTrigger : MonoBehaviour
{
    public RadioPodbor radioScript;
    public GameObject Radio;

    void OnTriggerEnter(Collider col)
    {
      if (col.tag == "Player")
      {
          radioScript.enabled = true; // Заходишь - запрашивает скрипт
      }  
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            radioScript.enabled = false; // выходишь - выключает скрипт и убирает картинку
            Radio.SetActive (false);
        }
    }
}
