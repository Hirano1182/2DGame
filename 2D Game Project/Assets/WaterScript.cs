using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterScript : MonoBehaviour
{
    public GameObject WaterPrefab;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void update()
    {
        
        if (i <= 1000)
        {
            GameObject water0 = GameObject.Instantiate(WaterPrefab);
        }
        i++;


    }
}