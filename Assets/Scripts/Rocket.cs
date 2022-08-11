using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class Rocket : MonoBehaviour
{
    public Rigidbody2D rocketRigid;
    private Transform rocketTransform;
    private GameObject obj;
    private float flyForce = 10f;
    private Animator anim;
    private float movementx;

    public float gas;
    private float inGas;
    private float gasLoss = 70f;

    [SerializeField]
    public bool isGround;

    [SerializeField]
    public float initialHeight;
    void Start()
    {
        obj = gameObject;
        rocketRigid = obj.GetComponent<Rigidbody2D>();
        rocketTransform = obj.transform;
        anim = obj.GetComponent<Animator>();
        anim.SetBool("Fly", false);
        gas = 100f;
        isGround = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (rocketRigid.IsSleeping())
        {
            rocketRigid.WakeUp();
        }
        if (Input.GetButton("Jump"))
        {
            if (gas > 0)
            {
                rocketRigid.AddForce(new Vector3(0, flyForce * Time.deltaTime, 0), ForceMode2D.Impulse);
                gas -= gasLoss * Time.deltaTime;
            }
        }
        if (isGround == false)
        {
            movementx = Input.GetAxisRaw("Horizontal");
            rocketTransform.position += new Vector3(5 * movementx * Time.deltaTime, 0, 0);
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        inGas = gas;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Gas station"))
        {
            if (gas < 100f)
            {
                gas += (100f - inGas) * Time.deltaTime / 1;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ha"))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = false;
            initialHeight = transform.position.y;
        }
    }
}