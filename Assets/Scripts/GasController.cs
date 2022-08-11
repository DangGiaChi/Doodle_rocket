using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasController : MonoBehaviour
{
    private GameObject obj;
    private GameObject rocket;
    private Vector3 gasBar;
    private Vector3 scaleInitial;
    void Start()
    {
        obj = this.gameObject;
        rocket = GameObject.FindWithTag("Rocket");
        gasBar = obj.transform.localScale;
        scaleInitial = obj.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        gasBar.y = scaleInitial.y * rocket.GetComponent<Rocket>().gas / 100f;
        obj.transform.localScale = gasBar;
    }
}
