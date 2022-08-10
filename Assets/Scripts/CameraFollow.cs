using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform rocket;
    private Vector3 tempPos;
    private GameObject obj;
    private bool firstJump;
    private GameObject[] gasStation;

    private GameObject background;
    void Start()
    {
        obj = this.gameObject;
        rocket = GameObject.FindWithTag("Rocket").transform;
        firstJump = false;
        gasStation = GameObject.FindGameObjectsWithTag("Gas station");
        background = GameObject.FindWithTag("Sky");
    }

    // Update is called once per frame
    void Update()
    {
        gasStation = GameObject.FindGameObjectsWithTag("Gas station");
        if (Input.GetButtonDown("Jump"))
        {
            firstJump = true;
        }
        tempPos = obj.transform.position;
        tempPos.y = rocket.transform.position.y;
        if (firstJump)
        {
            setColliderGasStation(false);
            if (tempPos.y > obj.transform.position.y)
            {
                obj.transform.position = tempPos;
            }
            if (tempPos.y < obj.transform.position.y)
            {
                setColliderGasStation(true);
            }
        }
    }

    void setColliderGasStation(bool colliderBool)
    {
        for(int i = 0; i < gasStation.Length; ++i)
        {
            gasStation[i].GetComponent<GasStation>().colliderOn = colliderBool;
        }
    }
}
