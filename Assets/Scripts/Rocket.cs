using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public Rigidbody2D rocketRigid;
    private GameObject obj;
    public float flyForce = 15f;
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
            rocketRigid.AddForce(new Vector3(0, flyForce * Time.deltaTime, 0), ForceMode2D.Impulse);
        }
    }
}
