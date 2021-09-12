using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life4 : MonoBehaviour
{
    public string targetObjectName; // 目標オブジェクト名：Inspectorで指定
    public string hideObjecttName;  // 消すオブジェクト名：Inspectorで指定

    GameObject hideObject;
    float orgY = 0;
    float ofsetY = 10000; // この値をY方向に足すことで消す

    private const int MAX_LIFE_COUNT = 3;
    private int lifeCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    { // 衝突したとき
      // もし、衝突したものの名前が目標オブジェクトだったら
        if (collision.gameObject.name == targetObjectName && lifeCount == 2)
        {
            // 消す【hideObject.SetActive(false); の代わり】
            Vector3 pos = hideObject.transform.position;
            pos.y = orgY + ofsetY;
            hideObject.transform.position = pos;
        }
    }
}
