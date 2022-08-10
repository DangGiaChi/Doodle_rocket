using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform rocket;
    private Vector3 tempPos;
    private GameObject obj;
    private bool firstJump;
    void Start()
    {
        obj = this.gameObject;
        rocket = GameObject.FindWithTag("Rocket").transform;
        firstJump = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            firstJump = true;
        }
        tempPos = obj.transform.position;
        tempPos.y = rocket.transform.position.y;
        if (firstJump)
        {
            if (tempPos.y > obj.transform.position.y)
            {
                obj.transform.position = tempPos;
            }
        }
    }
}
