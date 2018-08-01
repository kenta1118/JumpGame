using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftController : MonoBehaviour {

    BoxCollider LiftCollider;
    bool setOff = true;
    GameObject player;
    GameObject mainCamera;

	// Use this for initialization
	void Start () {

        LiftCollider = GetComponent<BoxCollider>();
        player = GameObject.Find("Player");
        mainCamera = Camera.main.gameObject;
	}

    // Update is called once per frame
    void Update()
    {
        float liftHeight = transform.position.y;
        float cameraHeight = mainCamera.transform.position.y;

        if (player.GetComponent<PlayerController>().jumpEnd == true)
        {
            LiftCollider.enabled = true;
        }

        if (player.GetComponent<PlayerController>().jumpEnd == false)
        {
            LiftCollider.enabled = false;
        }

        if(liftHeight < cameraHeight - 3.5f)
        {
            float liftPosX = 0;
            int number = Random.Range(0, 7);
            switch(number)
            {
                case 0:
                    liftPosX = -3.25f;
                    break;

                case 1:
                    liftPosX = -2;
                    break;

                case 2:
                    liftPosX = -1;
                    break;

                case 3:
                    liftPosX = 0f;
                    break;

                case 4:
                    liftPosX = 1f;
                    break;

                case 5:
                    liftPosX = 2f;
                    break;

                case 6:
                    liftPosX = 3.25f;
                    break;
            }
            float liftPosY = cameraHeight + 3.5f;

            transform.position = new Vector3(liftPosX, liftPosY, transform.position.z);
        }
    }
}
