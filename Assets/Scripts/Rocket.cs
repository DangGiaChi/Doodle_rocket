using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public Rigidbody2D rocketRigid;
    private Transform rocketTransform;
    private GameObject obj;
    private float flyForce = 10f;
    private Animator anim;
    private float movementx;

    public float gas;
    private float gasLoss = 70f;
    void Start()
    {
        obj = gameObject;
        rocketRigid = obj.GetComponent<Rigidbody2D>();
        rocketTransform = obj.transform;
        anim = obj.GetComponent<Animator>();
        anim.SetBool("Fly", false);
        gas = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            if (gas > 0)
            {
                rocketRigid.AddForce(new Vector3(0, flyForce * Time.deltaTime, 0), ForceMode2D.Impulse);
                gas -= gasLoss*Time.deltaTime;
            }
        }
        movementx = Input.GetAxisRaw("Horizontal");
        rocketTransform.position += new Vector3(5 * movementx * Time.deltaTime, 0, 0);
        
        Animate();
    }

    void Animate()
    {
        if (Input.GetButton("Jump"))
        {
            if (gas > 0)
            {
                anim.SetBool("Fly", true);
            }
            else
            {
                anim.SetBool("Fly", false);
            }
        }
        else
        {
            anim.SetBool("Fly", false);
        }
    }
}
