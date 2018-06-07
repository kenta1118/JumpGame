using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackButtonController : MonoBehaviour {

    GameObject player;
    Button attackButton;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
        attackButton = GameObject.Find("Canvas/AttackButton").GetComponent<Button>();
    }
	
	// Update is called once per frame
	void Update () {
		if(player.GetComponent<PlayerController>().speed == 0)
        {
            attackButton.interactable = false;
        }
        else
        {
            attackButton.interactable = true;
        }
	}

    public void OnClick()
    {
        player.GetComponent<PlayerController>().Attack();
    }
}
