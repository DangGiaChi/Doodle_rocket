using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCount : MonoBehaviour
{
    GameObject Rocket;
    private float initialRocketHeight;
    public TextMeshProUGUI score;
    void Start()
    {
        Rocket = GameObject.FindWithTag("Rocket");
        initialRocketHeight = Rocket.GetComponent<Rocket>().initialHeight;
    }

    // Update is called once per frame
    void Update()
    {
        if (Rocket.GetComponent<Rocket>().isGround == false)
        {
            score.text = "Height: " + ((Rocket.transform.position.y - initialRocketHeight) * 100f).ToString("F0");
        }
    }
}
