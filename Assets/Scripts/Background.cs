using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    private Vector3 tempPos;
    private GameObject obj;
    public float flySpeed = 0f;
    public float resetRange = 27.65f;
    void Start()
    {
        obj = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("MainCamera"))
        {
            tempPos = obj.transform.position;
            tempPos.y += resetRange;

            obj.transform.position = tempPos;
        }
    }
}
