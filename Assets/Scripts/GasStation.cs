using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasStation : MonoBehaviour
{
    private GameObject obj;
    private BoxCollider2D colliderGas;

    [SerializeField]
    public bool colliderOn;
    void Start()
    {
        obj = gameObject;
        colliderGas = obj.GetComponent<BoxCollider2D>();
        colliderOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        colliderGas.enabled = colliderOn;
    }
}
