using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsPloshatka : MonoBehaviour
{
    public bool isvidno=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnBecameVisible()
    {
        isvidno = !isvidno;
    }
}
