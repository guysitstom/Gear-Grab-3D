using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim_Controller : MonoBehaviour
{
    private Animator anim;
    private Rigidbody rb;
    private enum MovementState { Idle, Walking, Jumping, Running}
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateAnimationState();
    }
    private void UpdateAnimationState()
    {
        MovementState state;
        if (rb.velocity.y > 0f|| rb.velocity.x > 0f)
        {
            state = MovementState.Walking;
        }
        else if (rb.velocity.y < 0f || rb.velocity.x < 0f)
        {
            state = MovementState.Walking;
        }
        else
        {
            state = MovementState.Idle;
        }

        if (rb.velocity.y > .1f)
        {
            state = MovementState.Jumping;
        }

        anim.SetInteger("state", (int)state);
    }
}
