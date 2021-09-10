using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summon_Something : MonoBehaviour
{
    public string thing;
    public bool Check = false;
    GameObject Thing;

    void Start()
    {
        Thing = GameObject.Find(thing);
    }

    public void Invoke()
    {
        Instantiate(this);
        Check = true;
    }
}
