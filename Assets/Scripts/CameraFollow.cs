using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform rocket;
    private Vector3 tempPos;
    private GameObject obj;
    void Start()
    {
        obj = this.gameObject;
        rocket = GameObject.FindWithTag("Rocket").transform;
    }

    // Update is called once per frame
    void Update()
    {
        tempPos = obj.transform.position;
        tempPos.y = rocket.transform.position.y;

        obj.transform.position = tempPos;
    }
}
