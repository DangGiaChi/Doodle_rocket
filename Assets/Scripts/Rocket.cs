using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public Rigidbody2D rocketRigid;
    private GameObject obj;
    public float flySpeed = 20f;
    void Start()
    {
        obj = this.gameObject;
        rocketRigid = obj.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            obj.transform.position += new Vector3(0, flySpeed * Time.deltaTime, 0);
        }
    }
}
