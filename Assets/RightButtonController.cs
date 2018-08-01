using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightButtonController : MonoBehaviour {

    GameObject player;
    Button rightButton;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
        rightButton = GameObject.Find("Canvas/RightButton").GetComponent<Button>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick()
    {
        Vector3 playerPos = player.transform.position;
        playerPos.x += 1f;
    }
}
