using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forever_wave : MonoBehaviour
{
    public float xspeed = 1; // スピード：Inspectorで指定
    public float yspeed = 1;

    public int maxcount = 50;
    int count;

    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    { // ずっと行う（一定時間ごとに）
        count = count + 1;
        this.transform.Translate(xspeed / 50, 0, 0); // 水平移動する
       
        if(count <= maxcount)
        {
            this.transform.Translate(0, yspeed / 50, 0);
        }
        if(count >= maxcount)
        {
            this.transform.Translate(0, -yspeed / 50, 0);
        }
        if(count >= maxcount * 2)
        {
            count = 0;
        }

    }
}

