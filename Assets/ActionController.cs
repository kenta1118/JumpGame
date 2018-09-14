using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionController : StateMachineBehaviour
{
    GameObject player;
    
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (stateInfo.IsName("Walk"))
        {
            player = GameObject.Find("Player");
            player.GetComponent<PlayerController>().speed = 2.0f;
        }

        if(stateInfo.IsName("Jump"))
        {
            player = GameObject.Find("Player");
            player.GetComponent<PlayerController>().jumpEnd = false;
        }
    }


    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (stateInfo.IsName("Jump"))
        {
            player.GetComponent<PlayerController>().jumpEnd = true;
        }
    }
}
