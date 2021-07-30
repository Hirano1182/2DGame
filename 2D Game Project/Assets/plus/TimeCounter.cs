using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimeCounter : MonoBehaviour
{

    public static float countdown;
    public float startcount = 500;

    public Text timeText;
    // Start is called before the first frame update
    void Start()
    {
        countdown = startcount;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        timeText.text = countdown.ToString("f0");

        if(countdown <= 0)
        {
            timeText.text = "time up!";
        }

    }
}
