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
    public float realmaxspeed = 1;
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

    public Transform invent = null;
    public float inventDY = 0;
    private Rigidbody rig = null;

    [SerializeField] private float m_StepInterval;
    [SerializeField] private AudioClip[] m_FootstepSounds;
    private AudioSource m_AudioSource;
    private float m_StepCycle;
    private float m_NextStep;
    private void Awake()
    {
        ChContrlr = GetComponent<CapsuleCollider>();
        rig = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        //Camerarig = SteamVR_Render.Top().origin;
        //head = SteamVR_Render.Top().head;
        m_StepCycle = 0f;
        m_NextStep = m_StepCycle/2f;
	    rig.maxDepenetrationVelocity = 1;
        m_AudioSource = GetComponent<AudioSource>();
    }
    void Update()
    {

invent.transform.eulerAngles = new Vector3(0,head.eulerAngles.y,0);
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

        movement += new Vector3(m.x,0,m.y) * maxspeed * Time.deltaTime;

        
        
        rig.AddForce(movement , ForceMode.Impulse);
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
    ChContrlr.center = newCenter;

    Vector3 inventoryCenter = newCenter;
    inventoryCenter.y += inventDY;
	invent.transform.localPosition = inventoryCenter;
        //newCenter = Quaternion.Euler(0,-transform.eulerAngles.y,0) * newCenter;

        
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
void FixedUpdate()
   {
         if(rig.velocity.magnitude > realmaxspeed)
         {
                rig.velocity = rig.velocity.normalized * realmaxspeed;
         }
         ProgressStepCycle(0);
    }
    private void PlayFootStepAudio()
        {
            if (!m_AudioSource.isPlaying){
                if (!(jump <= 0))
                {
                    return;
                }
            
            int n = Random.Range(1, m_FootstepSounds.Length);
            m_AudioSource.clip = m_FootstepSounds[n];
            m_AudioSource.PlayOneShot(m_AudioSource.clip);
            
            m_FootstepSounds[n] = m_FootstepSounds[0];
            m_FootstepSounds[0] = m_AudioSource.clip;
            }
        }
    private void ProgressStepCycle(float speed)
        {
            if (rig.velocity.sqrMagnitude > 0)
            {
                m_StepCycle += (rig.velocity.magnitude + speed)*Time.fixedDeltaTime;
            }

            if (!(m_StepCycle > m_NextStep))
            {
                return;
            }

            m_NextStep = m_StepCycle + m_StepInterval;

            PlayFootStepAudio();
        }
}
