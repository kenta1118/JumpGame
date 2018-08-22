using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {

    public GameObject player;
    public GameObject mainCamera;
    public GameObject gameOver;
    public GameObject RightJumpButton;
    public GameObject LeftJumpButton;
    public GameObject hp1;
    public GameObject hp2;
    public GameObject hp3;
    private Color Gray = new Color(152.0f / 255.0f, 152.0f / 255.0f, 152.0f / 255.0f, 255.0f / 255.0f);

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
        mainCamera = Camera.main.gameObject;
        gameOver = GameObject.Find("GameOver");
        //RightJumpButton = GameObject.Find("Canvas/RightJumpButton").GetComponent<Button>();
        RightJumpButton = GameObject.Find("RightJumpButton");
        LeftJumpButton = GameObject.Find("LeftJumpButton");
        hp1 = GameObject.Find("HP1");
        hp2 = GameObject.Find("HP2");
        hp3 = GameObject.Find("HP3");
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

        if(player.activeSelf == false)
        {
            gameOver.GetComponent<Text>().enabled = true;
            hp1.GetComponent<Image>().color = Gray;
            hp2.GetComponent<Image>().color = Gray;
            hp3.GetComponent<Image>().color = Gray;
        }
    }
}
