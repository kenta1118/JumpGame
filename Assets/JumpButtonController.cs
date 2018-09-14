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
        PlayerController playerCont = player.GetComponent<PlayerController>();

        //空中でのジャンプを禁止（ジャンプボタンの非アクティブ化）
        if (playerCont.isGrounded == false && playerCont.OnLift == false)
        {
            jumpButton.interactable = false;
        }
        else
        {
            jumpButton.interactable = true;
        }

        if (playerCont.OnLift == true)
        {
            jumpButton.interactable = true;
        }
	}

    public void OnClick()
    {
        player.GetComponent<PlayerController>().Jump();
    }
}
