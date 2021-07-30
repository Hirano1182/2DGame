using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCounter_Limit : MonoBehaviour
{
    public string targetObjectName;
    public int Ammo = 20;
    int addValue = 1;
    bool flag = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    { // 衝突したとき
      // もし、衝突したものの名前が目標オブジェクトだったら
        if (collision.gameObject.name == targetObjectName)
        {
            // カウンターの値を増やす
            flag = true;
            GameCounter.value =Ammo;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("up") && GameCounter.value >= 0 && flag == true)
        {

            GameCounter.value = GameCounter.value - addValue;
         


        }
        if (GameCounter.value <= 0)
        {
            flag = false;
        }

    }
}
