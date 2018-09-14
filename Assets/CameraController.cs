using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player;
    float cameraHeight;
    
    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float playerHeight = player.transform.position.y + 1.5f;
        float cameraHeight = transform.position.y;
        float newHeight = Mathf.Lerp(cameraHeight, playerHeight, 0.05f);
        PlayerController playerCont = player.GetComponent<PlayerController>();

        //playerがカメラの高さを超えて、リフトに着地したらカメラ移動
        if(playerHeight > cameraHeight && playerCont.OnLift == true)
        {
            transform.position = new Vector3(transform.position.x, newHeight, transform.position.z);
        }
        //playerがカメラから見切れたら消す
        if(playerHeight + 1.0f < cameraHeight)
        {
            player.SetActive(false);
        }
    }
}
