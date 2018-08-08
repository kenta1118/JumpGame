using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightButtonController : MonoBehaviour {

    GameObject player;
    bool OnButton = false;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
    }
	
	// Update is called once per frame
	void Update () {
		if(OnButton == true)
        {
            Vector3 playerPos = player.transform.localPosition;
            playerPos.x += (1.0f * Time.deltaTime);
        }
	}

    public void OnRightButtonDown()
    {
        OnButton = true;
    }

    public void OnRightButtonUp()
    {
        OnButton = false;
    }
}
