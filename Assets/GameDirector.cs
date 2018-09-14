using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {

    GameObject player;
    GameObject mainCamera;
    GameObject gameOver;
    GameObject RightJumpButton;
    GameObject LeftJumpButton;
    GameObject hp1;
    GameObject hp2;
    GameObject hp3;
    GameObject jumpButton;
    private Color Gray = new Color(152.0f / 255.0f, 152.0f / 255.0f, 152.0f / 255.0f, 255.0f / 255.0f);

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
        mainCamera = Camera.main.gameObject;
        gameOver = GameObject.Find("GameOver");
        RightJumpButton = GameObject.Find("RightJumpButton");
        LeftJumpButton = GameObject.Find("LeftJumpButton");
        hp1 = GameObject.Find("HP1");
        hp2 = GameObject.Find("HP2");
        hp3 = GameObject.Find("HP3");
        jumpButton = GameObject.Find("JumpButton");
    }
	
	// Update is called once per frame
	void Update () {
        PlayerController playerCont = player.GetComponent<PlayerController>();
        //playerが落下してカメラから見切れると全HPをグレーにする
        if(player.activeSelf == false)
        {
            gameOver.GetComponent<Text>().enabled = true;
            hp1.GetComponent<Image>().color = Gray;
            hp2.GetComponent<Image>().color = Gray;
            hp3.GetComponent<Image>().color = Gray;
        }
    }
}
