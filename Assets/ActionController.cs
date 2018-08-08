using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionController : StateMachineBehaviour
{

    GameObject player;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (stateInfo.IsName("Walk"))
        {
            player = GameObject.Find("Player");
            player.GetComponent<PlayerController>().speed = 2.0f;
        }

        if (stateInfo.IsName("Attack"))
        {
            player = GameObject.Find("Player");
            if(player.GetComponent<PlayerController>().isGrounded == true)
            {
                player.GetComponent<PlayerController>().speed = 0;
            }
        }

        if(stateInfo.IsName("Jump"))
        {
            player = GameObject.Find("Player");
            player.GetComponent<PlayerController>().jumpEnd = false;
        }
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}


    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (stateInfo.IsName("Jump"))
        {
            player.GetComponent<PlayerController>().jumpEnd = true;
        }
    }

    // OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}
}
