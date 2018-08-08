using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public bool RMove_flag = false;
    public bool LMove_flag = false;
    public bool RJump_flag = false;
    public bool LJump_flag = false;
    Button RightButton;
    Button LeftButton;
    Button RightJumpButton;
    Button LeftJumpButton;

    //private CharacterController controller;


	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        RightButton = GameObject.Find("Canvas/RightButton").GetComponent<Button>();
        LeftButton = GameObject.Find("Canvas/LeftButton").GetComponent<Button>();
        RightJumpButton = GameObject.Find("Canvas/RightJumpButton").GetComponent<Button>();
        LeftJumpButton = GameObject.Find("Canvas/LeftJumpButton").GetComponent<Button>();
    }
	
	// Update is called once per frame
	void Update () {

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

        if(RMove_flag == true)
        {
            RightMove();
        }

        if(LMove_flag == true)
        {
            LeftMove();
        }

        if(RJump_flag == true)
        {
            RightJump();
        }

        if(LJump_flag == true)
        {
            LeftJump();
        }

        if(isGrounded == false)
        {
            RightButton.interactable = false;
            LeftButton.interactable = false;
        }

        if (isGrounded == true || OnLift == true)
        {
            RightButton.interactable = true;
            LeftButton.interactable = true;
        }
    }

    public void Jump()
    {
        rb.AddForce(Vector3.up * 350);
        animator.SetTrigger("IsJump");
        isGrounded = false;
        OnLift = false;
        cameraMove = true;
    }

    public void RightPushDown()
    {
        RMove_flag = true;
    }

    public void RightPushUp()
    {
        RMove_flag = false;
        animator.SetBool("IsWalk", false);
    }

    public void LeftPushDown()
    {
        LMove_flag = true;
        animator.SetBool("IsWalk", true);
    }

    public void LeftPushUp()
    {
        LMove_flag = false;
        animator.SetBool("IsWalk", false);
    }

    public void RightJumpPushDown()
    {
        RJump_flag = true;
    }

    public void RightJumpPushUp()
    {
        RJump_flag = false;
    }

    public void LeftJumpPushDown()
    {
        LJump_flag = true;
    }

    public void LeftJumpPushUp()
    {
        LJump_flag = false;
    }

    public void RightMove()
    {
        transform.position += transform.forward * Time.deltaTime * speed;
        transform.rotation = Quaternion.Euler(0, 90, 0);
        animator.SetBool("IsWalk", true);
    }

    public void LeftMove()
    {
        transform.position += transform.forward * Time.deltaTime * speed;
        transform.rotation = Quaternion.Euler(0, 270, 0);
        animator.SetTrigger("IsWalk");
    }

    public void RightJump()
    {
        rb.AddForce(Vector3.up * 350);
        animator.SetTrigger("IsJump");
        transform.position += transform.forward * Time.deltaTime * speed;
        isGrounded = false;
        OnLift = false;
        cameraMove = true;
    }

    public void LeftJump()
    {
        rb.AddForce(Vector3.up * 350);
        animator.SetTrigger("IsJump");
        transform.position += transform.forward * Time.deltaTime * speed;
        isGrounded = false;
        OnLift = false;
        cameraMove = true;
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
