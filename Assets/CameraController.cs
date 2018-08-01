using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    GameObject player;
    public float cameraHeight;
    private Transform playerTransform;

    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("Player");
        playerTransform = player.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float playerHeight = player.transform.position.y + 1.5f;
        float cameraHeight = transform.position.y;
        float newHeight = Mathf.Lerp(cameraHeight, playerHeight, 0.5f);
        //transform.position = new Vector3(transform.position.x, playerPos.y + 1.5f, transform.position.z);
        //cameraHeight = transform.position.y;

        //if (player.GetComponent<PlayerController>().Fall == true)
        //{
        //    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        //}

        if(playerHeight > cameraHeight || player.GetComponent<PlayerController>().cameraMove == true
            && player.GetComponent<PlayerController>().liftCount == 0)
        {
            transform.position = new Vector3(transform.position.x, newHeight, transform.position.z);
        }
    }
}
