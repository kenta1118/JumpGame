﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftGenerator : MonoBehaviour {

    public GameObject lift;
    public bool case0_flag = false;
    public bool case1_flag = false;
    public bool case2_flag = false;
    public bool case3_flag = false;
    public bool case4_flag = false;
    public bool case5_flag = false;
    public bool case6_flag = false;

    // Use this for initialization
    void Start () {
        float liftPosX = transform.position.x;
        int number1 = Random.Range(0, 7);
        int number2 = Random.Range(0, 2);
        switch(number1)
        {
            case 0:
                if(case0_flag == true)
                {
                    liftPosX = -2.0f;
                    case0_flag = false;
                }
                else
                {
                    liftPosX = -3.25f;
                }
                case0_flag = true;
                break;

            case 1:
                if(case1_flag == true)
                {
                    if(number2 == 0)
                    {
                        liftPosX = -3.25f;
                    }
                    else if(number2 == 1)
                    {
                        liftPosX = -1.0f;
                    }
                    case1_flag = false;
                }
                else
                {
                    liftPosX = -2.0f;
                }
                case1_flag = true;
                break;

            case 2:
                if(case2_flag == true)
                {
                    if(number2 == 0)
                    {
                        liftPosX = -2.0f;
                    }
                    else if(number2 == 1)
                    {
                        liftPosX = 0;
                    }
                    else
                    {
                        liftPosX = -1.0f;
                    }
                    case2_flag = false;
                }
                case2_flag = true;
                break;

            case 3:
                if (case3_flag == true)
                {
                    if (number2 == 0)
                    {
                        liftPosX = -1.0f;
                    }
                    else if (number2 == 1)
                    {
                        liftPosX = 1.0f;
                    }
                    else
                    {
                        liftPosX = 0;
                    }
                    case3_flag = false;
                }
                case3_flag = true;
                break;

            case 4:
                if (case4_flag == true)
                {
                    if (number2 == 0)
                    {
                        liftPosX = 0;
                    }
                    else if (number2 == 1)
                    {
                        liftPosX = 2.0f;
                    }
                    else
                    {
                        liftPosX = 1.0f;
                    }
                    case4_flag = false;
                }
                case4_flag = true;
                break;

            case 5:
                if (case5_flag == true)
                {
                    if (number2 == 0)
                    {
                        liftPosX = 1.0f;
                    }
                    else if (number2 == 1)
                    {
                        liftPosX = 3.25f;
                    }
                    else
                    {
                        liftPosX = 2.0f;
                    }
                    case5_flag = false;
                }
                case5_flag = true;
                break;

            case 6:
                if (case6_flag == true)
                {
                    liftPosX = 2.0f;
                    case6_flag = false;
                }
                else
                {
                    liftPosX = 3.25f;
                }
                case6_flag = true;
                break;
        }
        Vector3 pos = new Vector3(liftPosX, transform.position.y, transform.position.z);
        Instantiate(lift, pos, transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
