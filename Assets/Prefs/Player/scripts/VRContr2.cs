using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class VRContr2 : MonoBehaviour
{

    public float g = 30f;
    public float Sensitivity = 0.1f;
    public float maxspeed = 1;
    public float maxjump = 1;
    public float RotateIncrement = 90;
    
    public SteamVR_Action_Boolean RotatePress = null;
    public SteamVR_Action_Boolean MovePress = null;
    public SteamVR_Action_Vector2 movevalue = null;

    public SteamVR_Action_Boolean JumpPress = null;

    private float speed = 0.0f;
    private float jump = 0.0f;

    private CapsuleCollider ChContrlr = null;
    public Transform Camerarig = null;
    public Transform head = null;
    private Rigidbody rig = null;
    private void Awake()
    {
        ChContrlr = GetComponent<CapsuleCollider>();
        rig = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        //Camerarig = SteamVR_Render.Top().origin;
        //head = SteamVR_Render.Top().head;

	rig.maxDepenetrationVelocity = 1;
    }
    void Update()
    {
        //HandleHead();
        HandleHeight();
        CalculateMovement();
        //snapRotation();
        if (jump > 0){
        jump -= Time.deltaTime;
        }
        if (JumpPress.GetStateDown(SteamVR_Input_Sources.LeftHand)){
            if (jump <= 0){
            rig.AddForce(transform.up*maxjump, ForceMode.Impulse );
            jump = 0.5f;
            }
                
            
            //Debug.Log("fff");
        }
        
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

        Vector2 m = movevalue.axis;
		m = Quaternion.Euler(0, 0, -head.rotation.eulerAngles.y) * m;

        movement += new Vector3(m.x,0,m.y) * maxspeed ;

        
        
        rig.AddForce(movement, ForceMode.Impulse);
    }

    void HandleHeight()
    {
        
        float headheight = Mathf.Clamp(head.localPosition.y,1,2);
        ChContrlr.height = headheight;


        Vector3 newCenter = Vector3.zero;
        newCenter.y = ChContrlr.height / 2;
        newCenter.y += ChContrlr.radius;

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
