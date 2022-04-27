using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwitchAnimation : MonoBehaviour
{
    Animator animator;
    float timeToAnimEnd;
    // Start is called before the first frame update
    void Awake()
    {
        animator = GetComponentInChildren<Animator>();

        ChangeClip();
    }


    void ChangeClip()
    {
        int rand = Random.Range(0, 2);

        animator.SetInteger("ClipNumber",rand);
        
        timeToAnimEnd = animator.GetCurrentAnimatorStateInfo(0).length;

        Invoke("ChangeClip", timeToAnimEnd);
    }
}
