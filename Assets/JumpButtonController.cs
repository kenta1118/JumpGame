using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpButtonController : MonoBehaviour {

    GameObject player;
    Button jumpButton;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
        jumpButton = GameObject.Find("Canvas/JumpButton").GetComponent<Button>();
	}
	
	// Update is called once per frame
	void Update () {

        if(player.GetComponent<PlayerController>().isGrounded == false || player.GetComponent<PlayerController>().speed == 0)
        {
            jumpButton.interactable = false;
        }
        else
        {
            jumpButton.interactable = true;
        }

        if(player.GetComponent<PlayerController>().OnLift == true)
        {
            jumpButton.interactable = true;
        }

        if(player.GetComponent<PlayerController>().RMove_flag == true
            || player.GetComponent<PlayerController>().LMove_flag == true)
        {
            jumpButton.interactable = false;
        }

        //if (player.GetComponent<PlayerController>().speed == 0)
        //{
        //    jumpButton.interactable = false;
        //}
		
	}

    public void OnClick()
    {
        player.GetComponent<PlayerController>().Jump();
    }
}
