using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boxing : MonoBehaviour
{
    public Transform cactus1;
    public Transform cactus2;
    Animator cactus1Animator;
    Animator cactus2Animator;

    void Start()
    {
        cactus1Animator = cactus1.GetComponent<Animator>();
        cactus2Animator = cactus2.GetComponent<Animator>();
    }

    void Update()
    {
        float distance = Vector3.Distance(cactus1.position, cactus2.position);

        if (distance <= 0.10f)
        {
            cactus1Animator.Play("Cactus@Attack");
            cactus2Animator.Play("Cactus@Attack");
        }
        else
        {
            cactus1Animator.Play("Cactus@Idle");
            cactus2Animator.Play("Cactus@Idle");
        }
    }

    void OnBecameInvisible()
    {
        cactus1Animator.Play("Cactus@Idle");
        cactus2Animator.Play("Cactus@Idle");
    }

    void OnBecameVisible()
    {
        float distance = Vector3.Distance(cactus1.position, cactus2.position);

        if (distance <= 0.10f)
        {
            cactus1Animator.Play("Cactus@Attack");
            cactus2Animator.Play("Cactus@Attack");
        }
    }
}


