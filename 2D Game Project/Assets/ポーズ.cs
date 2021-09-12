using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ポーズ : MonoBehaviour
{
    public string showObjectName;  // 表示オブジェクト名：Inspectorで指定

    GameObject showObject;
    float orgY = 0;
    float ofsetY = 10000; // この値をY方向に足すことで消す

        // Start is called before the first frame update
        void Start()
    {
            // 消す前に表示オブジェクトを覚えておいて
            showObject = GameObject.Find(showObjectName);

            // 消す【showObject.SetActive(false); の代わり】
            orgY = showObject.transform.position.y;
            if (orgY > ofsetY)
            {
                orgY -= ofsetY;
            }
            Vector3 pos = showObject.transform.position;
            pos.y = orgY + ofsetY;
            showObject.transform.position = pos;
        }

    void OnMouseDown()
    { // タッチしたら
        Vector3 pos = showObject.transform.position;
        pos.y = orgY;
        showObject.transform.position = pos;

        // Update is called once per frame
        void Update()
    {
        
    }
    }
}

