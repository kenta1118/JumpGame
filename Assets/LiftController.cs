using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftController : MonoBehaviour {

    BoxCollider LiftCollider;
    bool setOff = true;

	// Use this for initialization
	void Start () {

        LiftCollider = GetComponent<BoxCollider>();
	}
	
	// Update is called once per frame
	void Update () {

		if(setOff == true)
        {
            LiftCollider.enabled = false;
        }

        if(setOff == false)
        {
            LiftCollider.enabled = true;
        }
	}

    //private void OnCollisionExit(Collision col)
    //{
    //    if(col.gameObject.tag == "Player")
    //    {
    //        setOff = true;
    //    }
    //}

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            setOff = false;
        }
    }
}
