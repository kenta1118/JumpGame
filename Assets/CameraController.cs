﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    GameObject player;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 playerPos = this.player.transform.position;
        transform.position = new Vector3(transform.position.x, playerPos.y + 1.5f, transform.position.z);
	}
}
