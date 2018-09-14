using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontLiftController : MonoBehaviour {

    BoxCollider LiftCollider;
    GameObject player;

    // Use this for initialization
    void Start () {
        LiftCollider = GetComponent<BoxCollider>();
        player = GameObject.Find("Player");
    }
	
	// Update is called once per frame
	void Update () {
        PlayerController playerCont = player.GetComponent<PlayerController>();

        //ジャンプ時はリフトのcolliderをOFFして下から貫通可能にして、着地時にcolliderをONにする
        if (playerCont.jumpEnd == true)
        {
            LiftCollider.enabled = true;
        }

        if (playerCont.jumpEnd == false)
        {
            LiftCollider.enabled = false;
        }
    }
}
