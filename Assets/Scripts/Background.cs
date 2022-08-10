using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    private Vector3 oldPosition;
    private GameObject obj;
    public float flySpeed = 0f;
    private float moveRange = 17.55f;
    void Start()
    {
        obj = gameObject;
        oldPosition = obj.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            obj.transform.position += new Vector3(0, -flySpeed * Time.deltaTime, 0);
        }
        if (Vector3.Distance(oldPosition, obj.transform.position) > moveRange)
        {
            if (obj.CompareTag("Sky"))
            {
                obj.transform.position = oldPosition;
            }
        }
    }
}
