using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCountDown : MonoBehaviour
{
    public int CD;
    public string ObjectName;
    GameObject Object;
    public bool dog = true;

    // Start is called before the first frame update
    void Start()
    {
        Object = GameObject.Find(ObjectName);
    }

    // Update is called once per frame
    void Update()
    {
        if(CD <= 0 && dog)
        {
            Object.SendMessage("Invoke");
            dog = false;
        }
    }

    void OnCollisionEnter2D()
    {
        CD--;
    }

    void Invoke()
    {

    }
}
