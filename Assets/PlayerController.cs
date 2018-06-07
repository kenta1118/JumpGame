using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Animator animator;
    Rigidbody rb;
    public float speed = 2.0f;
    public float jumpPower = 200.0f;
    Vector3 velocity;
    public bool isGrounded = true;
    public bool OnLift = false;
    AnimatorStateInfo stateInfo;
    //private CharacterController controller;


	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        //controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {

        transform.position += transform.forward * Time.deltaTime * speed;

        //if (Input.GetMouseButton(0) && isGrounded == true && jumpEnd == false && IsJumping == false)
        //{
        //    jumpPower++;
        //    if(jumpPower >= 35)
        //    {
        //        jumpEnd = true;
        //        isGrounded = true;
        //        IsJumping = true;
        //    }
        //    rb.AddForce(Vector3.up * jumpPower);
        //}

        //    if(Input.GetMouseButtonUp(0) && isGrounded == true)
        //    {
        //        if(IsJumping == true)
        //        {
        //            isGrounded = true;
        //            jumpEnd = false;
        //        }
        //    }

        //    if(Input.GetMouseButtonUp(0))
        //    {
        //        jumpPower = 0;
        //        IsJumping = false;
        //    }
    }

    public void Jump()
    {
        rb.AddForce(Vector3.up * 400);
        animator.SetTrigger("IsJump");
        isGrounded = false;
        OnLift = false;
    }

    public void Attack()
    {
        if (isGrounded == true)
        {
            speed = 0;
        }
        animator.SetTrigger("IsAttack");
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Wall")
        {
            transform.Rotate(new Vector3(0f, 180.0f, 0f));
        }

        if (col.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }

        if(col.gameObject.tag == "OnLift")
        {
            OnLift = true;
        }
    }

    private void OnCollisionExit(Collision col)
    {
        if(col.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }

        if(col.gameObject.tag == "OnLift")
        {
            OnLift = false;
        }
    }
}
