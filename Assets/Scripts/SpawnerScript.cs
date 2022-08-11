using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject reference;
    public GameObject spawnedStation;
    public float min, max;
    public float range;
    Vector3 oldPos;
    void Awake()
    {
        oldPos = transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y - oldPos.y > range)
        {
            spawnedStation = Instantiate(reference);
            spawnedStation.transform.position = new Vector3(Random.Range(min, max), transform.position.y, 0);
            oldPos = transform.position;
        }
    }
}
