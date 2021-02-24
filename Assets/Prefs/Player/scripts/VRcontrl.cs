using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class VRcontrl : MonoBehaviour
{

    public float g = 30f;
    public float Sensitivity = 0.1f;
    public float maxspeed = 1;
    public float RotateIncrement = 90;
    
    public SteamVR_Action_Boolean RotatePress = null;
    public SteamVR_Action_Boolean MovePress = null;
    public SteamVR_Action_Vector2 movevalue = null;

    private float speed = 0.0f;

    private CharacterController ChContrlr = null;
    public Transform Camerarig = null;
    public Transform head = null;

    private void Awake()
    {
        ChContrlr = GetComponent<CharacterController>();
    }

    private void Start()
    {
        //Camerarig = SteamVR_Render.Top().origin;
        //head = SteamVR_Render.Top().head;
    }
    void Update()
    {
        //HandleHead();
        HandleHeight();
        CalculateMovement();
        //snapRotation();
        
    }

    void HandleHead()
    {
        Vector3 oldpos = Camerarig.position;
        
        Quaternion oldrotation =  Camerarig.rotation;

        transform.eulerAngles = new Vector3(0.0f,head.rotation.eulerAngles.y,0.0f);

        Camerarig.position = oldpos;
        Camerarig.rotation = oldrotation;
    }

    void CalculateMovement()
    {
        Vector3 orintEuler = new Vector3(0,head.eulerAngles.y,0);
        Quaternion orint = Quaternion.Euler(orintEuler);

        Vector3 movement = Vector3.zero;

        if (MovePress.GetStateUp(SteamVR_Input_Sources.Any))
        {
            speed = 0;
        }

        if (MovePress.state)
        {
            speed += movevalue.axis.y * Sensitivity;
            speed = Mathf.Clamp(speed,-maxspeed,maxspeed);

            

            
        }

        Vector2 m = movevalue.axis;
		m = Quaternion.Euler(0, 0, -head.rotation.eulerAngles.y) * m;

        movement += new Vector3(m.x,0,m.y) * maxspeed ;

        movement.y -= g * Time.deltaTime;

        ChContrlr.Move(movement * Time.deltaTime);
    }

    void HandleHeight()
    {
        
        float headheight = Mathf.Clamp(head.localPosition.y,1,2);
        ChContrlr.height = headheight;


        Vector3 newCenter = Vector3.zero;
        newCenter.y = ChContrlr.height / 2;
        newCenter.y += ChContrlr.skinWidth;

        newCenter.x = head.localPosition.x;  
        newCenter.z = head.localPosition.z;

        //newCenter = Quaternion.Euler(0,-transform.eulerAngles.y,0) * newCenter;

        ChContrlr.center = newCenter;
    }
    private void snapRotation()
    {
        float snapValue = 0;

        if (RotatePress.GetStateDown(SteamVR_Input_Sources.LeftHand))
        {
            snapValue = -Mathf.Abs(RotateIncrement);
        }
        if (RotatePress.GetStateDown(SteamVR_Input_Sources.RightHand))
        {
            snapValue = Mathf.Abs(RotateIncrement);
        }

        transform.RotateAround(head.position,Vector3.up,snapValue);
    }
}
