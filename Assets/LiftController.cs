using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftController : MonoBehaviour {

    BoxCollider LiftCollider;
    bool setOff = true;
    GameObject player;

	// Use this for initialization
	void Start () {

        LiftCollider = GetComponent<BoxCollider>();
        player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {

        if(player.GetComponent<PlayerController>().jumpEnd == true)
        {
            LiftCollider.enabled = true;
        }

        if(player.GetComponent<PlayerController>().jumpEnd == false)
        {
            LiftCollider.enabled = false;
        }
		//if(setOff == true)
  //      {
  //          LiftCollider.enabled = false;
  //      }

  //      if(setOff == false)
  //      {
  //          LiftCollider.enabled = true;
  //      }
	}

    //private void OnCollisionExit(Collision col)
    //{
    //    if (col.gameObject.tag == "Player")
    //    {
    //        setOff = true;
    //    }
    //}

    //private void OnCollisionEnter(Collision col)
    //{
    //    if(col.gameObject.tag == "Player")
    //    {
    //        setOff = false;
    //    }
    //}
}
