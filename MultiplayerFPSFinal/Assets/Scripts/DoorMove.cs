using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMove : MonoBehaviour
{
    [Tooltip("The position to move this object to. The object will move back to it's starting position, if you want.")]
    public GameObject doorL;
    public GameObject doorR;
    public Transform targetPositionL;
    public Transform targetPositionR;
    [Tooltip("How fast the object moves, in units per second.")]
    public float moveSpeed;
    [Tooltip("Should the object start moving on scene start?")]
    public bool moveOnStart;

    public bool poweredDoor = false;
    private Vector3 startPostionL;
    private Vector3 startPostionR;
    private bool moving, moveToTarget = true;
    private bool openDoor = true;

    Vector3 targetPosL;
    Vector3 targetPosR;

    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        startPostionL = doorL.transform.position;
        startPostionR = doorR.transform.position;
  /*      if (targetPosition.parent == transform)
            targetPosition.parent = null;*/
        if (moveOnStart)
            Move();
    }
    private void Update()
    {
/*        if (!moving) return;
        if (openDoor)
        {
            targetPosL = targetPositionL.position;
            targetPosR = targetPositionR.position;
        }
        else
        {
            targetPosL = startPostionL;
            targetPosR= startPostionR;
        } 
        doorL.transform.position = Vector3.MoveTowards(doorL.transform.position, targetPosL, Time.deltaTime * moveSpeed);
        doorR.transform.position = Vector3.MoveTowards(doorR.transform.position, targetPosR, Time.deltaTime * moveSpeed);
        
        if (doorL.transform.position == targetPosL && doorR.transform.position == targetPosR)
        {                   
            moving = false;            
        }*/

    }

    public void Move()
    {
        //if (moving) return;
        //moveToTarget = transform.position == startPostion ? true : false;
        
        moving = true;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            animator.SetTrigger("OpenDoor");
            
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            animator.SetTrigger("CloseDoor");
        }
    }
}
