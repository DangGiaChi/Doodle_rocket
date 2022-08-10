using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasStation : MonoBehaviour
{
    private GameObject obj;
    private BoxCollider2D colliderGas;
    private Animator anim;

    [SerializeField]
    public bool colliderOn;
    void Start()
    {
        obj = gameObject;
        colliderGas = obj.GetComponent<BoxCollider2D>();
        colliderOn = false;
        anim = obj.GetComponent<Animator>();
        anim.SetBool("isCharge", false);
    }

    // Update is called once per frame
    void Update()
    {
        colliderGas.enabled = colliderOn;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Rocket"))
        {
            anim.SetBool("isCharge", true);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Rocket"))
        {
            anim.SetBool("isCharge", false);
        }
    }
}
