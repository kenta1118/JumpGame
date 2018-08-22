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
        if (player.GetComponent<PlayerController>().jumpEnd == true)
        {
            LiftCollider.enabled = true;
        }

        if (player.GetComponent<PlayerController>().jumpEnd == false)
        {
            LiftCollider.enabled = false;
        }
    }
}
