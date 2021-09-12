using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move3 : MonoBehaviour
{
    GameObject chara;
    int speed;

    // Start is called before the first frame update
    void Start()
    {
        chara = GameObject.Find("chara");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            speed = 4;
            chara.GetComponent<Rigidbody2D>().velocity = new Vector3(speed, chara.GetComponent<Rigidbody2D>().velocity.y, 0);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            speed = 4;
            chara.GetComponent<Rigidbody2D>().velocity = new Vector3(-speed, chara.GetComponent<Rigidbody2D>().velocity.y, 0);
        }
    }
}
