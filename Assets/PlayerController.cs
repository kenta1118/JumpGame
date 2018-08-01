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
    public bool jumpEnd = false;
    public bool Fall = false;
    public int liftCount = 0;
    public bool cameraMove = false;
    //private CharacterController controller;


	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        //controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {

        //transform.position += transform.forward * Time.deltaTime * speed;
        velocity = Vector3.zero;

        if(jumpEnd == true && isGrounded == false)
        {
            Fall = true;
        }
        if(jumpEnd == true && OnLift == false)
        {
            Fall = true;
        }
        if(isGrounded == true || OnLift == true)
        {
            Fall = false;
        }

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
        rb.AddForce(Vector3.up * 350);
        animator.SetTrigger("IsJump");
        isGrounded = false;
        OnLift = false;
        cameraMove = true;
    }

    public void RightMove()
    {
        transform.position += transform.forward * Time.deltaTime;
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
            liftCount++;
            cameraMove = false;
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
