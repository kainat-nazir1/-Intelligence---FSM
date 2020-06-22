using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMyVision : MonoBehaviour
{
    public enum enumSensitivty { HIGh, LOW};

    public enumSensitivty sensitivty = enumSensitivty.HIGh;

    public bool targetInSight = false;

    public float fieldOfVision = 45f;

    public Transform myEyes = null;

    private Transform target = null;

    public Transform npcTransform = null;

    private SphereCollider spherecollider = null;

    public Vector3 lastKnownSight = Vector3.zero;


    // Start is called before the first frame update

    private void Awake()
    {
        npcTransform = GetComponent<Transform>();
        spherecollider = GetComponent<SphereCollider>();
        lastKnownSight = npcTransform.position;
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }

    bool InMyFieldOfVision()
    {
        Vector3 dirToTarget = target.position;

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
