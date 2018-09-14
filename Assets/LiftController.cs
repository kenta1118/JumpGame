using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftController : MonoBehaviour
{

    BoxCollider LiftCollider;
    GameObject player;
    GameObject mainCamera;
    GameObject score;
    public int lift_count = 0;

    // Use this for initialization
    void Start()
    {
        LiftCollider = GetComponent<BoxCollider>();
        player = GameObject.Find("Player");
        mainCamera = Camera.main.gameObject;
        score = GameObject.Find("Score2");
    }

    // Update is called once per frame
    void Update()
    {
        float liftHeight = transform.position.y;
        float cameraHeight = mainCamera.transform.position.y;
        PlayerController playerCont = player.GetComponent<PlayerController>();

        //ジャンプ時はリフトのcolliderをOFFして下から貫通可能にして、着地時にcolliderをONにする
        if (playerCont.jumpEnd == true)
        {
            LiftCollider.enabled = true;
        }
        if (playerCont.jumpEnd == false)
        {
            LiftCollider.enabled = false;
        }

        //リフトがカメラから見切れたら上部に移動し、Ⅹ軸はランダムで配置
        if (liftHeight < cameraHeight - 1.7f)
        {
            float liftPosX = transform.position.x;
            int number1 = Random.Range(0, 7);
            int number2 = Random.Range(0, 2);

            switch (number1)
            {
                case 0:
                    liftPosX = -2.75f;
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
                    liftPosX = 2.75f;
                    break;
            }
            float liftPosY = cameraHeight + 4.5f;
            transform.position = new Vector3(liftPosX, liftPosY, transform.position.z);
        }

        if(playerCont.OnLift == true)
        {
            lift_count++;
        }
    }
}
