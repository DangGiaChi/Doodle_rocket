using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public Rigidbody2D rocketRigid;
    private GameObject obj;
    public float flyForce = 15f;
    private Animator anim;

    public float gas;
    private float gasLoss = 70f;
    void Start()
    {
        obj = this.gameObject;
        rocketRigid = obj.GetComponent<Rigidbody2D>();
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
