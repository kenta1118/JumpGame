using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {

    public GameObject player;
    GameObject mainCamera;
    GameObject gameOver;
    public GameObject RightJumpButton;
    public GameObject LeftJumpButton;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
        mainCamera = Camera.main.gameObject;
        gameOver = GameObject.Find("GameOver");
        //RightJumpButton = GameObject.Find("Canvas/RightJumpButton").GetComponent<Button>();
        RightJumpButton = GameObject.Find("RightJumpButton");
        LeftJumpButton = GameObject.Find("LeftJumpButton");
    }
	
	// Update is called once per frame
	void Update () {
        if (player.GetComponent<PlayerController>().RMove_flag == true)
        {
            RightJumpButton.SetActive(true);
        }
        else
        {
            RightJumpButton.SetActive(false);
        }

        if (player.GetComponent<PlayerController>().LMove_flag == true)
        {
            LeftJumpButton.SetActive(true);
        }
        else
        {
            LeftJumpButton.SetActive(false);
        }
    }
}
