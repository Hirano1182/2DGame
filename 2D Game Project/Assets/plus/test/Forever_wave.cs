using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forever_wave : MonoBehaviour
{
    public float xspeed = 1; // �X�s�[�h�FInspector�Ŏw��
    public float yspeed = 1;

    public int maxcount = 50;
    int count;

    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    { // �����ƍs���i��莞�Ԃ��ƂɁj
        count = count + 1;
        this.transform.Translate(xspeed / 50, 0, 0); // �����ړ�����
       
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

