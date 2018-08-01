using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {

    GameObject player;
    GameObject mainCamera;
    GameObject gameOver;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("player");
        mainCamera = Camera.main.gameObject;
        gameOver = GameObject.Find("GameOver");
    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
