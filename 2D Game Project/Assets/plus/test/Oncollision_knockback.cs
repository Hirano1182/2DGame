using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oncollision_knockback : MonoBehaviour
{
    public string targetObjectName;
    Rigidbody2D rbody;
    // Start is called before the first frame update
    void Start()
    {
        
        rbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            this.rbody.AddForce(new Vector2(100,10));
           
        }
    }
}
