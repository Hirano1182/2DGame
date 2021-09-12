using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float x_val;
    private float speed;
    public float inputSpeed;
    public float jumpingPower;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        x_val = Input.GetAxis("Horizontal");
        //Spaceが押された場合
        if (Input.GetKeyDown("space"))
        {
            rb2d.AddForce(Vector2.up * jumpingPower);
        }
    }
    void FixedUpdate()
    {
        //待機
        if (x_val == 0)
        {
            speed = 0;
        }
        //右に移動
        else if (x_val > 0)
        {
            speed = inputSpeed;
        }
        //左に移動
        else if (x_val < 0)
        {
            speed = inputSpeed * -1;
        }
        // キャラクターを移動 Vextor2(x軸スピード、y軸スピード(元のまま))
        rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
    }
}