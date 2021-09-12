using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnKeyPress_MoveSprite4 : MonoBehaviour
{
    public float speed = 2; //スピード：Inspecterで指定

    float vx = 0;
    float vy = 0;
    bool leftFlag = false;
    // Update is called once per frame
    void Update()
    {
        vx = 0;
        vy = 0;
        if (Input.GetKey("right"))
        {
            vx = speed;
            leftFlag = false;
        }
        if (Input.GetKey("left"))
        {
            vy = -speed;
            leftFlag = false;
        }
    }
    private void FixedUpdate()
    {
        this.transform.Translate(vx / 50, vy / 50, 0);

        this.GetComponent<SpriteRenderer>().flipX = leftFlag;
    }
}
