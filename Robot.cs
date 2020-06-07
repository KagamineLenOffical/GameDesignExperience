using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;

    CharacterController controller;
    Animator animator;
    State n_state = State.Idle;
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        bool isRun = false;
        Vector3 dir = Vector3.zero;
        if (Input.GetKey(KeyCode.A))
        {
            isRun = true;
            dir += Vector3.left;
        }
        if (Input.GetKey(KeyCode.S))
        {
            isRun = true;
            dir += Vector3.back;
        }
        if (Input.GetKey(KeyCode.D))
        {
            isRun = true;
            dir += Vector3.right;
        }
        if (Input.GetKey(KeyCode.W))
        {
            isRun = true;
            dir += Vector3.forward;
        }
        dir.Normalize();
        if (controller.isGrounded)
        {
            Grounded(true);
            Run(isRun, dir);
            if (Input.GetKey(KeyCode.U))
            {
                SetState(State.Attack);
                Attack();
            }
        }
        else
        {
            Grounded(false);
        }
        if (Input.GetKey(KeyCode.Space) && controller.isGrounded)
        {
            Jump();

        }
        else if (Input.GetKeyUp(KeyCode.Space) && controller.isGrounded)
        {
            Idle();
        }
        moveDirection.y -= gravity * Time.deltaTime;
        if (isRun)
        {
            controller.transform.forward = (IgnoreY(moveDirection));
        }
        controller.Move(moveDirection * Time.deltaTime);
    }
    void Attack()
    {
        animator.SetTrigger("Attack");
    }
    void Grounded(bool g)
    {
        animator.SetBool("Grounded",g);
    }
    Vector3 IgnoreY (Vector3 i)
    {
        i.y = 0;
        return i;
    }
    void Idle()
    {
        SetState(State.Idle);
    }
    void Jump()
    {
        SetState(State.Jump);
        moveDirection.y = jumpSpeed;
    }
    void Run(bool isRun,Vector3 dir)
    {
        if (isRun)
        {
            SetState(State.Run);
        }
        else SetState(State.Idle);
        moveDirection = dir;
        moveDirection *= speed;
    }
    void SetState(State newState)
    {
        n_state = newState;
        
        animator.SetBool("Idle", n_state == State.Idle);
        animator.SetBool("Jump", n_state == State.Jump);
        //animator.SetBool("Attack", n_state == State.Attack);
        animator.SetBool("Run", n_state == State.Run);
        
    }
    enum State
    {
        Idle=1,Run,Jump,Attack
    }
}
